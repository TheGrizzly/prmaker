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
    public partial class FrmTourneys : Form
    {
        int idRanking;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;Convert Zero Datetime=true;";
        List<string> tourneyNames = new List<string>();
        List<int> idTourneys = new List<int>();
        List<string> playerNames = new List<string>();
        Regex regexItem = new Regex("^[a-zA-Z0-9 ]*$");
        DateTime FirstT;
        DateTime LastT;

        public FrmTourneys(int idr)
        {
            InitializeComponent();
            idRanking = idr;
        }

        private void getTourneys()
        {
            tourneyNames.Clear();
            idTourneys.Clear();
            playerNames.Clear();
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
                    int i = 0;
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
                            btnBuscar.Enabled = true;
                            btnVer.Enabled = true;
                            if (i == 0)
                            {
                                FirstT = reader.GetDateTime(3);
                                dtpFirstDate.Value = FirstT;
                            }
                            i++;
                        }
                    }
                    int index = dgvTourneys.Rows.Count-2;
                    string date = Convert.ToString( dgvTourneys.Rows[index].Cells[3].Value);
                    LastT = Convert.ToDateTime(date);
                    dtpLastDate.Value = LastT;
                }
                else
                {
                    btnBuscar.Enabled = false;
                    btnVer.Enabled = false;
                    btnFiltrar.Enabled = false;
                    dtpFirstDate.Enabled = false;
                    dtpLastDate.Enabled = false;
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
            getTourneys();
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string SearchedTourney = Interaction.InputBox("Ingrese el nombre del torneo", "Buscar Torneo", "Buscar Torneo");
            dgvTourneys.Rows.Clear();
            tourneyNames.Clear();
            idTourneys.Clear();
            playerNames.Clear();
            dgvTourneys.Rows.Clear();
            if(SearchedTourney == "")
            {
                getTourneys();
            }else if (SearchedTourney.Length > 30)
            {
                MessageBox.Show("Texto demaciado grande");
            }else if (regexItem.IsMatch(SearchedTourney))
            {
                string query = "CALL SearchTourneyByName(" +idRanking+ ", '" + SearchedTourney + "')";

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
            }
        }


        private void btnVer_Click(object sender, EventArgs e)
        {
            int idTourneySelected = 0;
            string[] TN = tourneyNames.ToArray<string>();
            if (dgvTourneys.SelectedCells.Count > 1 || dgvTourneys.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione la celda con el torneo que deseas ver");
            }
            else if (dgvTourneys.CurrentCell.ColumnIndex != 1)
            {
                MessageBox.Show("Selecciona la celda con el torneo que deseas ver");
            }
            else
            {
                idTourneySelected = idTourneys[tourneyNames.IndexOf(dgvTourneys.CurrentCell.Value.ToString())];

                FrmTournament FrmT = new FrmTournament(idTourneySelected, idRanking);
                FrmT.ShowDialog();
                getTourneys();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(dtpFirstDate.Value == FirstT && dtpLastDate.Value == LastT)
            {
                MessageBox.Show("Favor de cambiar las fechas para poder filtrar");
            }
            else
            {
                dgvTourneys.Rows.Clear();
                string query = "CALL FilterTByDates('" + dtpFirstDate.Value.ToString("yyyy-MM-dd HH:mm:ss")+"', '"+ dtpLastDate.Value.ToString("yyyy-MM-dd HH:mm:ss")+"', "+idRanking+");";
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
                    // se cierra la conexion con la base de datos
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtpFirstDate_ValueChanged(object sender, EventArgs e)
        {
            dtpLastDate.MinDate = dtpFirstDate.Value;
        }

        private void dtpLastDate_ValueChanged(object sender, EventArgs e)
        {
            dtpFirstDate.MaxDate = dtpLastDate.Value;
        }
    }
}
