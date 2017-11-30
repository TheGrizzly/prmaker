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
    public partial class FrmPlayerStat : Form
    {
        int idRankingSelected;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        int idPlayerSelected;
        int loses = 0;
        int wins = 0;
        List<string> Nplayer1 = new List<string>();
        List<string> Nplayer2 = new List<string>();
        List<string> Ntourney = new List<string>();
        List<int> ScoreP1 = new List<int>();
        List<int> ScoreP2 = new List<int>();
        List<int> rplayer1 = new List<int>();
        List<int> rplayer2 = new List<int>();
        List<string> sets = new List<string>();
        List<string> PlayedSet = new List<string>();
        List<int> winsSet = new List<int>();
        List<int> lostSet = new List<int>();


        public void GetStats1()
        {
            lbSetScore.Items.Clear();
            lbSetScore.Items.Add("Set Score:");
            lbSetScore.Items.Add("");

            string query = "CALL PlayerStat1(" + idRankingSelected + ", " + idPlayerSelected + ");";

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
                    if (reader.Read())
                    {
                        lblTag.Text = reader.GetString(0);
                        lblRating.Text = reader.GetInt32(1).ToString();
                        lblMain.Text = reader.GetString(2);
                    }
                }

                databaseConnection.Close();

                string query2 = "CALL PlayerStat2(" + idPlayerSelected + ");";
                MySqlCommand PlayerStat2 = new MySqlCommand(query2, databaseConnection);
                PlayerStat2.CommandTimeout = 60;

                databaseConnection.Open();
                reader = PlayerStat2.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        lblNumTourey.Text = reader.GetInt32(0).ToString();
                        lblNoSets.Text = reader.GetInt32(1).ToString();
                    }
                }

                databaseConnection.Close();

                if (lblNoSets.Text == "0") ;

                else
                {
                    string query3 = "CALL PlyaerStat3(" + idPlayerSelected + ");";
                    PlayerStat2.CommandText = query3;

                    databaseConnection.Open();
                    reader = PlayerStat2.ExecuteReader();



                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Nplayer1.Add(reader.GetString(0));
                            Nplayer2.Add(reader.GetString(1));
                            Ntourney.Add(reader.GetString(2));
                            ScoreP1.Add(reader.GetInt32(3));
                            ScoreP2.Add(reader.GetInt32(4));
                            rplayer1.Add(reader.GetInt32(5));
                            rplayer2.Add(reader.GetInt32(6));
                            sets.Add(reader.GetString(0)+"("+reader.GetInt32(5).ToString()+") - "+ reader.GetString(1) + "(" + reader.GetInt32(6).ToString() + ")  "+reader.GetString(2)+"  "+reader.GetInt32(3).ToString()+"-"+reader.GetInt32(4).ToString());
                        }
                    }

                    databaseConnection.Close();

                    for(int i = 0; i < sets.Count; i++)
                    {
                        lbSetScore.Items.Add(sets[i]);
                    }

                    lbSetScore.Items.Add("");
                    lbSetScore.Items.Add("");

                    for(int i = 0; i < sets.Count; i++)
                    {
                        if (Nplayer1[i] == lblTag.Text)
                        {
                            if (PlayedSet.Contains(Nplayer2[i])) {
                                int j = PlayedSet.IndexOf(Nplayer2[i]);
                                if(ScoreP1[i] > ScoreP2[i])
                                {
                                    winsSet[j]++;
                                    wins++;
                                }else if(ScoreP1[i] < ScoreP2[i])
                                {
                                    lostSet[j]++;
                                    loses++;
                                }
                            }
                            else
                            {
                                PlayedSet.Add(Nplayer2[i]);
                                if (ScoreP1[i] > ScoreP2[i])
                                {
                                    winsSet.Add(1);
                                    wins++;
                                }else if (ScoreP2[i] > ScoreP1[i])
                                {
                                    lostSet.Add(1);
                                    loses++;
                                }
                                    
                            }
                        }else if (Nplayer2[i] == lblTag.Text)
                        {
                            if (PlayedSet.Contains(Nplayer1[i]))
                            {
                                int j = PlayedSet.IndexOf(Nplayer1[i]);
                                if (ScoreP1[i] < ScoreP2[i])
                                {
                                    winsSet[j]++;
                                    wins++;
                                }
                                else if (ScoreP1[i] > ScoreP2[i])
                                {
                                    lostSet[j]++;
                                    loses++;
                                }
                            }
                            else
                            {
                                PlayedSet.Add(Nplayer1[i]);
                                if (ScoreP1[i] < ScoreP2[i])
                                {
                                    winsSet.Add(1);
                                    wins++;
                                }
                                else if (ScoreP2[i] < ScoreP1[i])
                                {
                                    lostSet.Add(1);
                                    loses++;
                                }

                            }
                        }
                    }


                    for (int i = 0; i < PlayedSet.Count; i++)
                    {
                        lbSetScore.Items.Add(PlayedSet[i]+" "+winsSet[i]+"W - "+lostSet[i]+"L");
                    }

                    lblSetScore.Text = wins + "W / " + loses + "L";
                    double winrate, loserate;
                    winrate = wins / (wins + loses);
                    loserate = loses / (wins + loses);

                    winrate = Math.Round(winrate, 4);
                    loserate = Math.Round(loserate, 4);
                    winrate *= 100;
                    loserate *= 100;

                    lblWinRate.Text = winrate + "%";
                    lblLoseRate.Text = loserate + "%";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FrmPlayerStat(int idr, int idp)
        {
            InitializeComponent();
            idRankingSelected = idr;
            idPlayerSelected = idp;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditPlayer frmEdit = new FrmEditPlayer(idRankingSelected, idPlayerSelected, lblTag.Text, lblMain.Text);
            frmEdit.ShowDialog();
            GetStats1();
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            string query = "CALL DeletePlayerByName('" + lblTag.Text + "');";

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmPlayerStat_Load(object sender, EventArgs e)
        {
            GetStats1();
        }
    }
}
