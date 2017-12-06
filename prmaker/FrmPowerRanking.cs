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
    public partial class FrmPowerRanking : Form
    {
        string SelectedRanking;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        int idRanking;
        List<string> pName = new List<string>();
        List<string> pMain = new List<string>();
        List<string> pWinRate = new List<string>();
        List<string> pLoseRate = new List<string>();
        List<int> pWins = new List<int>();
        List<int> pLoses = new List<int>();
        List<int> pTotSets = new List<int>();
        List<int> pRating = new List<int>();
        List<int> PidPlayer = new List<int>();

        public void GetPR()
        {
            string query = "CALL PowerRanking1("+idRanking+");";

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
                    while (reader.Read())
                    {
                        pName.Add(reader.GetString(0));
                        pMain.Add(reader.GetString(1));
                        pRating.Add(reader.GetInt32(2));
                        PidPlayer.Add(reader.GetInt32(3));
                    }   
                }

                databaseConnection.Close();

                for(int i = 0; i < PidPlayer.Count; i++)
                {
                    string query2 = "CALL PlayerStat3(" + PidPlayer[i] + ");";
                    commandDatabase.CommandText = query2;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {
                        bool firstW = true;
                        bool firstL = true;
                        while (reader.Read())
                        {
                            if (reader.GetInt32(0) == PidPlayer[i])
                            {
                                if (reader.GetInt32(3) > reader.GetInt32(4))
                                {
                                    if (firstW)
                                    {
                                        pWins.Add(1);
                                        firstW = false;
                                    }
                                    else
                                    {
                                        pWins[i]++;
                                    }
                                }
                                else if (reader.GetInt32(3) < reader.GetInt32(4))
                                {
                                    if (firstL)
                                    {
                                        pLoses.Add(1);
                                        firstL = false;
                                    }
                                    else
                                        pLoses[i]++;
                                }
                            }
                            else if (reader.GetInt32(1) == PidPlayer[i])
                            {
                                if (reader.GetInt32(3) < reader.GetInt32(4))
                                {
                                    if (firstW)
                                    {
                                        pWins.Add(1);
                                        firstW = false;
                                    }
                                    else
                                        pWins[i]++;

                                }
                                else if (reader.GetInt32(3) > reader.GetInt32(4))
                                {
                                    if (firstL)
                                    {
                                        pLoses.Add(1);
                                        firstL = false;
                                    }
                                    else
                                        pLoses[i]++;
                                }
                            }
                        }
                        if (firstW)
                            pWins.Add(0);

                        if (firstL)
                            pLoses.Add(0);
                    }
                    else
                    {
                        pWins.Add(0);
                        pLoses.Add(0);
                    }

                    databaseConnection.Close();
                }
                

                for(int i = 0; i<pName.Count; i++)
                {
                    pTotSets.Add(pWins[i] + pLoses[i]);
                    if (pWins[i] + pLoses[i] == 0)
                    {
                        pWinRate.Add("0%");
                        pLoseRate.Add("0%");
                    }
                    else
                    {
                        int totalgames = pWins[i] + pLoses[i];
                        decimal WinR = Convert.ToDecimal(pWins[i]) / Convert.ToDecimal(totalgames);
                        decimal LoseR = Convert.ToDecimal(pLoses[i]) / Convert.ToDecimal(totalgames);
                        WinR = Math.Round(WinR, 4);
                        LoseR = Math.Round(LoseR, 4);
                        WinR *= 100;
                        LoseR *= 100;
                        WinR = Math.Round(WinR, 2);
                        LoseR = Math.Round(LoseR, 2);
                        pWinRate.Add(WinR + "%");
                        pLoseRate.Add(LoseR + "%");
                    }
                }

                for(int i =0; i < pName.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvPowerRanking.Rows[0].Clone();
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = pName[i];
                    row.Cells[2].Value = pMain[i];
                    row.Cells[3].Value = pWinRate[i];
                    row.Cells[4].Value = pLoseRate[i];
                    row.Cells[5].Value = pWins[i];
                    row.Cells[6].Value = pLoses[i];
                    row.Cells[7].Value = pTotSets[i];
                    row.Cells[8].Value = pRating[i];
                    dgvPowerRanking.Rows.Add(row);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FrmPowerRanking(int idr, string rName)
        {
            InitializeComponent();
            idRanking = idr;
            SelectedRanking = rName;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPowerRanking_Load(object sender, EventArgs e)
        {
            lblTitle.Text += SelectedRanking;
            GetPR();
        }

        private void dgvPowerRanking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
