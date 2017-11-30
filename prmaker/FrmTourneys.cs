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
    public partial class FrmTourneys : Form
    {
        int idRanking;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        List<string> tourneyNames = new List<string>();
        List<int> idTourneys = new List<int>();
        List<string> playerNames = new List<string>();

        public FrmTourneys(int idr)
        {
            InitializeComponent();
            idRanking = idr;
        }

        private void getTourneys()
        {
            dgvTourneys.Rows.Clear();

            string query = "CALL AllTourneys(" + idRanking + ")";

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
                        if (reader.GetString(0) == "")
                        {

                        }
                        else
                        {
                            DataGridViewRow row = (DataGridViewRow)dgvTourneys.Rows[0].Clone();
                            row.Cells[0].Value = reader.GetInt32(0);
                            row.Cells[1].Value = reader.GetString(1);
                            row.Cells[2].Value = reader.GetInt32(2);
                            row.Cells[3].Value = reader.GetDateTime(3);
                            row.Cells[4].Value = reader.GetInt32(4);
                            dgvTourneys.Rows.Add(row);
                            idTourneys.Add(reader.GetInt32(0));
                            tourneyNames.Add(reader.GetString(1));
                        }
                    }
                }
                else
                {
                    btnBuscar.Enabled = false;
                    btnEliminateTourney.Enabled = false;
                }

                // se cierra la conexion con la base de datos
                databaseConnection.Close();
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

        private void FrmTourneys_Load(object sender, EventArgs e)
        {
            getTourneys();
        }

        private void btnNewTournament_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNewTourney FrmNewT = new FrmNewTourney(idRanking, tourneyNames);
            FrmNewT.ShowDialog();
            this.Show();

            bool LastTourney = false;
            int idLastTourney = 0;
            string query = "Call LastTournament()";

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
                    if(reader.Read())
                    {
                        idLastTourney = reader.GetInt32(0);
                        LastTourney = true;
                    }
                }

                // se cierra la conexion con la base de datos
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (!LastTourney)
            {
                MessageBox.Show("No se encontro el torneo");
            }else
            {
                FrmPlayersTourney frmPT = new FrmPlayersTourney(idLastTourney, idRanking);
                frmPT.ShowDialog();   
            }
            FrmTournament FrmTour = new FrmTournament(idLastTourney);
            FrmTour.ShowDialog();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminateTourney_Click(object sender, EventArgs e)
        {

        }
    }
}
