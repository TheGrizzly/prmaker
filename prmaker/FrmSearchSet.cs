using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace prmaker
{
    public partial class FrmSearchSet : Form
    {
        int idTourney;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        List<int> setIdSet = new List<int>();
        List<int> setIdP1 = new List<int>();
        List<int> setIdP2 = new List<int>();
        List<string> setPName1 = new List<string>();
        List<string> setPName2 = new List<string>();
        List<int> setScoreP1 = new List<int>();
        List<int> setScoreP2 = new List<int>();
        List<int> setRatingP1 = new List<int>();
        List<int> setRatingP2 = new List<int>();
        
        public FrmSearchSet(int idt)
        {
            InitializeComponent();
            idTourney = idt;
        }

        public void GetMatches()
        {
            cboSets.Items.Clear();

            setIdSet.Clear();
            setPName1.Clear();
            setPName2.Clear();
            setIdP1.Clear();
            setIdP2.Clear();
            setScoreP1.Clear();
            setScoreP2.Clear();
            setRatingP1.Clear();
            setRatingP2.Clear();

            string query = "Call AllMatches("+idTourney+");";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // se hace una consulta con todos los jugadores y los meto al datagridview
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        setIdSet.Add(reader.GetInt32(0));
                        setIdP1.Add(reader.GetInt32(1));
                        setIdP2.Add(reader.GetInt32(2));
                        setScoreP1.Add(reader.GetInt32(3));
                        setScoreP2.Add(reader.GetInt32(4));
                        setRatingP1.Add(reader.GetInt32(5));
                        setRatingP2.Add(reader.GetInt32(6));
                    }
                }

                // se cierra la conexion con la base de datos
                databaseConnection.Close();

                query = "CALL PName1("+idTourney+");";

                commandDatabase.CommandText = query;

                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        setPName1.Add(reader.GetString(0));
                    }
                }

                databaseConnection.Close();

                query = "CALL PName2(" + idTourney + ");";

                commandDatabase.CommandText = query;

                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        setPName2.Add(reader.GetString(0));
                    }
                }

                databaseConnection.Close();

                for (int i = 0; i < setIdSet.Count; i++)
                {
                    cboSets.Items.Add(setPName1[i] + " (" + setRatingP1[i] + ") vs " + setPName2[i] + " (" + setRatingP2[i] + ")  " + setScoreP1[i] + " - " + setScoreP2[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int selectedset = cboSets.SelectedIndex;
            this.Hide();
            FrmSet FrmViewSet = new FrmSet(setIdSet[selectedset]);
            FrmViewSet.ShowDialog();
            this.Show();
        }

        private void cboSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSets.SelectedIndex >= 0)
            {
                btnSearch.Enabled = true;
            }
        }

        private void FrmSearchSet_Load(object sender, EventArgs e)
        {
            GetMatches();
        }
    }
}
