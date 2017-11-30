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
    public partial class FrmPlayersTourney : Form
    {
        int idRanking;
        int idTournament;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        List<string> playerNames = new List<string>();

        public FrmPlayersTourney(int idt, int idr)
        {
            InitializeComponent();
            idTournament = idt;
            idRanking = idr;
        }

        public void GetPlayers()
        {
            playerNames.Clear();

            string query = "CALL AllPlayerOnlyNames(" + idRanking + ");";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // se hace una consulta con todos los jugadores y los meto a un array globlal
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        playerNames.Add(reader.GetString(0));
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

        private void btnSelectPlayers_Click(object sender, EventArgs e)
        {
            int index;
            string player;
            try
            {
                foreach (int i in lbPlayers.SelectedIndices)
                {
                    index = lbPlayers.SelectedIndex;
                    player = lbPlayers.Items[index].ToString();
                    string query = "CALL PlayerTourneyByName(" + idTournament + ", '" + player + "');";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();

                        databaseConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Jugadores Agregados correctamente");
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmPlayersTourney_Load(object sender, EventArgs e)
        {
            GetPlayers();
            for(int i =0; i < playerNames.Count; i++)
            {
                lbPlayers.Items.Add(playerNames[i]);
            }
        }
    }
}
