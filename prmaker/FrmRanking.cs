using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace prmaker
{
    

    public partial class FrmRanking : Form
    {
        // variables globales que sirven para querys
        string SelectedRanking;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        int idRanking;
        List<string> RankingNames = new List<string>();
        Regex regexItem = new Regex("^[a-zA-Z0-9 ]*$");

        // constructor
        public FrmRanking(string ra, List<string> RNS)
        {
            InitializeComponent();
            SelectedRanking = ra;
            RankingNames = RNS;
        }

        public void getRankingData()
        {
            //creo el query y creo la conexion con la base de datos
            string query = "CALL SelectIdRanking('" + SelectedRanking + "');";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                //declaro el query en el reader
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                //veo si tiene valores la lectura
                if (reader.HasRows)
                {
                    while (reader.Read())
                        idRanking = reader.GetInt32(0);
                }
                else
                    MessageBox.Show("no dieron resultados");

                //cierro la conexion con la base de datos
                databaseConnection.Close();

                //creo el query para contar el numero de jugadores
                string query2 = "CALL NumOfPlayers(" + idRanking + ");";
                MySqlCommand callNumOfPlayers = new MySqlCommand(query2, databaseConnection);
                callNumOfPlayers.CommandTimeout = 60;

                databaseConnection.Open();

                reader = callNumOfPlayers.ExecuteReader();

                if (reader.HasRows)
                {
                    //cambio el texto de lblNum por el valor que me regresa
                    while (reader.Read())
                        lblNum.Text = reader.GetInt32(0).ToString();
                }
                else
                    MessageBox.Show("no dieron resultados");

                //cierro la connexion con la base de datos
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmRanking_Load(object sender, EventArgs e)
        {
            getRankingData();

        }


        // cierro la ventana
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarRankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creo el query y creo la conexion con la base de datos
            string query = "CALL DeleteRanking("+idRanking+");";
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
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cambiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NewName = Interaction.InputBox("Ingres el nuevo nombre del ranking", "editar ranking",SelectedRanking);
            bool repetido = false;
            
            for(int i = 0; i < RankingNames.Count; i++)
            {
                if (NewName == RankingNames[i] && NewName != SelectedRanking)
                    repetido = true;
            }

            if(NewName == "")
            {
                MessageBox.Show("Ingresa un valor");
            }else if(NewName == SelectedRanking)
            {
                MessageBox.Show("Es el mismo valor, favor de ingresar un nombre nuevo");
            }else if(NewName.Length > 30)
            {
                MessageBox.Show("Tamaño no valido");
            }else if (repetido)
            {
                MessageBox.Show("Ya existe ese valor, ingresa otro");
            }else if (!regexItem.IsMatch(NewName))
            {
                MessageBox.Show("Caracteres no validos, solo numeros y letras");
            }
            else
            {
                //creo el query y creo la conexion con la base de datos
                string query = "CALL EditRanking('" + NewName + "'," + idRanking + ");";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    //hago el update en el ranking
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    //cierro la connexion
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmPlayers frmJugadores = new FrmPlayers(idRanking);

            frmJugadores.ShowDialog();

            this.Show();
            getRankingData();
        }

        private void btnPersonajes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCharacters frmChars = new FrmCharacters();
            frmChars.ShowDialog();
            this.Show();
            getRankingData();
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTourneys frmTour = new FrmTourneys(idRanking);
            frmTour.ShowDialog();
            this.Show();
            getRankingData();
        }

        private void btnPr_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPowerRanking frmPr = new FrmPowerRanking(idRanking,SelectedRanking);
            frmPr.ShowDialog();
            this.Show();
            getRankingData();
        }
    }
}
