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
    public partial class FrmElimPlayer : Form
    {

        //variables globales
        int idRankingSelected;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";

        private void getPlayers()
        {
            cboPlayer.Items.Clear();

            string query = "CALL AllPlayerOnlyNames(" + idRankingSelected + ");";

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
                        cboPlayer.Items.Add(reader.GetString(0));
                    }
                }


                // se cierra la conexion con la base de datos
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FrmElimPlayer(int idrank)
        {
            InitializeComponent();
            idRankingSelected = idrank;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnElim.Enabled = true;
        }

        private void FrmElimPlayer_Load(object sender, EventArgs e)
        {
            getPlayers();
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            string query = "CALL DeletePlayerByName('" + cboPlayer.SelectedItem.ToString() + "');";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                //elimino el ranking
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                //cierro la connexion
                databaseConnection.Close();

                getPlayers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
