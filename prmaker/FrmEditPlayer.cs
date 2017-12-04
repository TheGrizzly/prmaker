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
    public partial class FrmEditPlayer : Form
    {
        public FrmEditPlayer(int idr, int idp, string pname, string cname)
        {
            InitializeComponent();
            idRankingSelected = idr;
            idSelectedPlayer = idp;
            playerName = pname;
            characterName = cname;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //variables globales
        int idRankingSelected;
        int idSelectedPlayer;
        string playerName, characterName;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        List<string> AllPlayerNames = new List<string>();
        Regex regexItem = new Regex("^[a-zA-Z0-9 ]*$");


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
            catch (Exception ex)
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

        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            if (!regexItem.IsMatch(txtTag.Text))
            {
                btnEdit.Enabled = false;
            }
            else if (AllPlayerNames.Count == 0)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                for (int i = 0; i < AllPlayerNames.Count; i++)
                {
                    if (txtTag.Text == AllPlayerNames[i] && txtTag.Text != playerName)
                    {
                        btnEdit.Enabled = false; 
                        break;
                    }
                    else
                    {
                        btnEdit.Enabled = true;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlDataReader myReader;

            if (txtTag.Text != playerName)
            {
                string query = "CALL EditPlayer('"+txtTag.Text+"', "+ idSelectedPlayer +");";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();

                    myReader = commandDatabase.ExecuteReader();

                    databaseConnection.Close();

                    MessageBox.Show("Nombre Actualizado correctamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            if(cboChars.SelectedItem.ToString() != characterName)
            {
                string query = "CALL EditCharDet(" + idSelectedPlayer + ", '" + cboChars.SelectedItem.ToString() + "');";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();

                    myReader = commandDatabase.ExecuteReader();

                    databaseConnection.Close();

                    MessageBox.Show("Main Actualizado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            this.Close();
        }

        private void FrmEditPlayer_Load(object sender, EventArgs e)
        {
            getChars();
            getPlayers();
            lblTitle.Text = playerName;
            txtTag.Text = playerName;
            cboChars.SelectedIndex = cboChars.Items.IndexOf(characterName);
        }
    }
}
