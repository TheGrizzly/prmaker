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
    public partial class FrmNewSet : Form
    {
        int idTournament;
        int Kvalue;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        List<string> PlayerNames = new List<string>();
        List<int> PlayerRatings = new List<int>();
        List<string> PlayerMains = new List<string>();

        public void GetData()
        {
            PlayerNames.Clear();
            PlayerRatings.Clear();
            PlayerMains.Clear();
            cboPlayer1.Items.Clear();
            cboPlayer2.Items.Clear();

            string query = "CALL GetDataForMatch("+idTournament+");";

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
                        PlayerNames.Add(reader.GetString(0));
                        PlayerRatings.Add(reader.GetInt32(1));
                        PlayerMains.Add(reader.GetString(2));
                    }
                }

                databaseConnection.Close();

                for(int i = 0; i < PlayerNames.Count; i++)
                {
                    cboPlayer1.Items.Add(PlayerNames[i]);
                    cboPlayer2.Items.Add(PlayerNames[i]);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public FrmNewSet(int idt, int kv)
        {
            InitializeComponent();
            idTournament = idt;
            Kvalue = kv;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPlayer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboPlayer1.SelectedIndex;
            lblRatingP1.Text = PlayerRatings[index].ToString();
            lblMainText1.Text = PlayerMains[index];
            if(cboPlayer1.SelectedIndex != -1 && cboPlayer2.SelectedIndex !=-1 && (nudScoreP1.Value != 0 || nudScoreP2.Value != 0) && cboPlayer1.SelectedIndex!=cboPlayer2.SelectedIndex)
            {
                btnAddMatch.Enabled = true;
            }
            else
            {
                btnAddMatch.Enabled = false;
            }
        }

        private void cboPlayer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboPlayer2.SelectedIndex;
            lblRatingP2.Text = PlayerRatings[index].ToString();
            lblMainText2.Text = PlayerMains[index];
            if (cboPlayer1.SelectedIndex >= 0 && cboPlayer2.SelectedIndex >= 0 && (nudScoreP1.Value != 0 || nudScoreP2.Value != 0) && cboPlayer1.SelectedIndex != cboPlayer2.SelectedIndex)
            {
                btnAddMatch.Enabled = true;
            }
            else
            {
                btnAddMatch.Enabled = false;
            }
        }

        private void nudScoreP1_ValueChanged(object sender, EventArgs e)
        {
            if (cboPlayer1.SelectedIndex >= 0 && cboPlayer2.SelectedIndex >= 0 && (nudScoreP1.Value != 0 || nudScoreP2.Value != 0) && cboPlayer1.SelectedIndex != cboPlayer2.SelectedIndex)
            {
                btnAddMatch.Enabled = true;
            }
            else
            {
                btnAddMatch.Enabled = false;
            }
        }

        private void nudScoreP2_ValueChanged(object sender, EventArgs e)
        {
            if (cboPlayer1.SelectedIndex >= 0 && cboPlayer2.SelectedIndex >= 0 && (nudScoreP1.Value != 0 || nudScoreP2.Value != 0) && cboPlayer1.SelectedIndex != cboPlayer2.SelectedIndex)
            {
                btnAddMatch.Enabled = true;
            }
            else
            {
                btnAddMatch.Enabled = false;
            }
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            string query = "CALL NewMatch('" + cboPlayer1.SelectedItem.ToString() + "', '"+cboPlayer2.SelectedItem.ToString()+"',"+idTournament+", "+nudScoreP1.Value+", "+nudScoreP2.Value+");";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Set añadido correctamente");

                databaseConnection.Close();
                int indexp1 = cboPlayer1.SelectedIndex;
                int indexp2 = cboPlayer2.SelectedIndex;

                double Qa = Math.Pow(10,PlayerRatings[indexp1]/400);
                double Qb = Math.Pow(10, PlayerRatings[indexp2]/400);
                double Ea = Qa / (Qa + Qb);
                double Eb = Qb / (Qa + Qb);
                double Sa;
                double Sb;
                double Raa;
                double Rab;

                if((nudScoreP1.Value==-1 && nudScoreP2.Value==0)|| (nudScoreP1.Value == 0 && nudScoreP2.Value == -1))
                {
                    Sa = Convert.ToDouble(nudScoreP1.Value / 1);
                    Sb = Convert.ToDouble(nudScoreP2.Value / 1);
                    if(nudScoreP1.Value==-1 && nudScoreP2.Value == 0)
                    {
                        Raa = Kvalue * (Sa - Ea);
                        Rab = 0;
                    }else if(nudScoreP1.Value==0 && nudScoreP2.Value == -1)
                    {
                        Raa = 0;
                        Rab = Kvalue * (Sa - Ea);
                    }
                }
                else
                {
                    Sa = Convert.ToDouble(nudScoreP1.Value / (nudScoreP1.Value + nudScoreP2.Value));
                    Sb = Convert.ToDouble(nudScoreP2.Value / (nudScoreP1.Value + nudScoreP2.Value));
                    Raa = Kvalue * (Sa - Ea);
                    Rab = Kvalue * (Sb - Eb);
                }
                
                Raa = Kvalue * (Sa - Ea);
                Rab = Kvalue * (Sb - Eb);

                int NRa = Convert.ToInt32(PlayerRatings[indexp1] + Math.Ceiling(Raa));
                int NRb = Convert.ToInt32(PlayerRatings[indexp2] + Math.Ceiling(Rab));

                string query2 = "CALL UpdateElo(" + NRa + ", " + NRb + ", '" + cboPlayer1.SelectedItem.ToString() + "', '" + cboPlayer2.SelectedItem.ToString() + "');";

                commandDatabase.CommandText = query2;

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se ha actualiza los rating correctamente");
                databaseConnection.Close();

                GetData();
                lblMainP1.Text = "Character";
                lblMainP2.Text = "Character";
                lblRatingP1.Text = "X000";
                lblRatingP2.Text = "X000";
                btnAddMatch.Enabled = false;
                nudScoreP1.Value = 0;
                nudScoreP2.Value = 0;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmNewSet_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
