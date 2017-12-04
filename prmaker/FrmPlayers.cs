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
    public partial class FrmPlayers : Form
    {

        //varaibles globlales
        int idRankingSelected;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        List<string> AllPlayerNames = new List<string>();
        Regex regexItem = new Regex("^[a-zA-Z0-9 ]*$");


        //constructor y asigno el idranking a la variable global
        public FrmPlayers(int idrank)
        {
            InitializeComponent();
            idRankingSelected = idrank;
        }

        private void GetAllPlayers()
        {
            dgvPlayers.Rows.Clear();
            AllPlayerNames.Clear();

            string query = "CALL AllPlayers(" + idRankingSelected + ")";

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
                            DataGridViewRow row = (DataGridViewRow)dgvPlayers.Rows[0].Clone();
                            AllPlayerNames.Add(reader.GetString(0));
                            row.Cells[0].Value = reader.GetString(0);
                            row.Cells[1].Value = reader.GetInt32(1).ToString();
                            row.Cells[2].Value = reader.GetInt32(2).ToString();
                            dgvPlayers.Rows.Add(row);
                        }
                    }
                }
                else
                {
                    btnBuscar.Enabled = false;
                    btnStats.Enabled = false;
                    btnEliminatePlayer.Enabled = false;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string SearchedPlayer  = Interaction.InputBox("Ingrese el nombre del jugador buscado", "Buscar Jugador", "Buscar Jugador");
            dgvPlayers.Rows.Clear();
            AllPlayerNames.Clear();
            if (SearchedPlayer == "")
            {
                GetAllPlayers();
            }else if (SearchedPlayer.Length > 30)
            {
                MessageBox.Show("Texto demaciado grande");
                GetAllPlayers();
            }
            else if (regexItem.IsMatch(SearchedPlayer)) {
                string query = "CALL SearchPlayerByName(" + idRankingSelected + ", '" + SearchedPlayer + "')";

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
                            DataGridViewRow row = (DataGridViewRow)dgvPlayers.Rows[0].Clone();
                            AllPlayerNames.Add(reader.GetString(0));
                            row.Cells[0].Value = reader.GetString(0);
                            row.Cells[1].Value = reader.GetInt32(1).ToString();
                            row.Cells[2].Value = reader.GetInt32(2).ToString();
                            dgvPlayers.Rows.Add(row);
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
            else
            {
                MessageBox.Show("Solo numeros y letras");
                GetAllPlayers();
            }
        }


        private void FrmPlayers_Load(object sender, EventArgs e)
        {
            GetAllPlayers();
        }

        private void btnEliminatePlayer_Click(object sender, EventArgs e)
        {
            FrmElimPlayer frmElim = new FrmElimPlayer(idRankingSelected);
            frmElim.ShowDialog();
            GetAllPlayers();
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnStats.Enabled = true;
            btnEliminatePlayer.Enabled = true;
            FrmAddPlayer frmAdd = new FrmAddPlayer(idRankingSelected);
            frmAdd.ShowDialog();
            GetAllPlayers();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            int idPlayerSelected = 0;
            string[] APN = AllPlayerNames.ToArray<string>();
            if (dgvPlayers.SelectedCells.Count > 1 || dgvPlayers.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione la celda con el nombre que desea ver mas detalladamente");
            }
            else if(dgvPlayers.CurrentCell.ColumnIndex !=0)
            {
                MessageBox.Show("Selecciona la celda con el nombre que desea ver mas detalladamente");
            }
            else
            {
                string selectedPlayer = dgvPlayers.CurrentCell.Value.ToString();

                string query = "CALL GetIdPlayer('" + selectedPlayer + "');";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (reader.Read())
                            idPlayerSelected = reader.GetInt32(0);

                        FrmPlayerStat frmStats = new FrmPlayerStat(idRankingSelected, idPlayerSelected);
                        frmStats.ShowDialog();
                        GetAllPlayers();
                    }
                    else
                    {
                        MessageBox.Show("no hay resultado");
                    }
                    // se cierra la conexion con la base de datos
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }
    }
}
