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
using System.Text.RegularExpressions;

namespace prmaker
{
    public partial class FrmAddPlayer : Form
    {
        
        //variables globales
        int idRankingSelected;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        List<string> AllPlayerNames = new List<string>();
        Regex regexItem = new Regex("^[a-zA-Z0-9 ]*$");

        public FrmAddPlayer(int idr)
        {
            InitializeComponent();
            idRankingSelected = idr;
        }

        private void getChars()
        {
            cboChars.Items.Clear();

            string query = "CALL AllCharacters;";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // se hace la conncecion a la base de datos y se saca los datos
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cboChars.Items.Add(reader.GetString(0));
                    }
                    // se cierra la conexion con la base de datos
                    databaseConnection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getPlayers()
        {
            AllPlayerNames.Clear();

            string query = "CALL AllPlayerOnlyNames(" + idRankingSelected + ");";

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
                        AllPlayerNames.Add(reader.GetString(0));                       
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddPlayer_Load(object sender, EventArgs e)
        {
            getChars();
            getPlayers();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int i = cboChars.TabIndex;

            string queryPlayer = "CALL NewPlayer('"+txtTag.Text+"', "+idRankingSelected+");";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(queryPlayer, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                databaseConnection.Close();

                string queryChar = "CALL PlayerMain('" + txtTag.Text + "', '" + cboChars.SelectedItem.ToString() + "', "+idRankingSelected+");";

                MySqlCommand CallDetmain = new MySqlCommand(queryChar, databaseConnection);
                CallDetmain.CommandTimeout = 60;

                databaseConnection.Open();

                myReader = CallDetmain.ExecuteReader();

                MessageBox.Show("Jugador añadido correctamente");

                databaseConnection.Close();

                txtTag.Text = "";
                btnNew.Enabled = false;
                getPlayers();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            if (!regexItem.IsMatch(txtTag.Text))
            {
                btnNew.Enabled = false;
            }else if (txtTag.Text == "")
                btnNew.Enabled = false;
            else if (AllPlayerNames.Count == 0 && cboChars.SelectedIndex >=0)
            {
                btnNew.Enabled = true;
            }
            else
            {
                for (int i = 0; i < AllPlayerNames.Count; i++)
                {
                    if ((txtTag.Text == AllPlayerNames[i] || txtTag.Text == "") && cboChars.SelectedIndex>=0)
                    {
                        btnNew.Enabled = false;
                        break;
                    }
                    else if(cboChars.SelectedIndex>=0)
                    {
                        btnNew.Enabled = true;
                    }
                }
            }

            
        }
    }
}
