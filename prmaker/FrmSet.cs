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
    public partial class FrmSet : Form
    {
        int idMatch;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        int ogscore1;
        int ogscore2;
        int lastmatch;
        int Kvalue;
        int idt;

        public void GetMatchData()
        {
            string query = "CALL MatchData("+idMatch+");";

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
                    {
                        ogscore1 = reader.GetInt32(6);
                        ogscore2 = reader.GetInt32(7);

                        lblTagP1.Text = reader.GetString(0);
                        lblTagP2.Text = reader.GetString(1);
                        lblRatingP1.Text = reader.GetInt32(2).ToString();
                        lblRatingP2.Text = reader.GetInt32(3).ToString();
                        lblMainP1.Text = reader.GetString(4);
                        lblMainP2.Text = reader.GetString(5);
                        nudScoreP1.Value = reader.GetInt32(6);
                        nudScoreP2.Value = reader.GetInt32(7);
                        lastmatch = reader.GetInt32(8);
                        Kvalue = reader.GetInt32(9);
                        idt = reader.GetInt32(10);
                    }
                }

                databaseConnection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FrmSet(int idm)
        {
            InitializeComponent();
            idMatch = idm;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres actualizar este set?", "borrar set", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "CALL EditMatch(" +nudScoreP1.Value+ ","+nudScoreP2.Value+", "+idMatch+");";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();

                    reader = commandDatabase.ExecuteReader();

                    databaseConnection.Close();

                    MessageBox.Show("set actualizado correctamente");

                    if (idMatch == lastmatch)
                    {
                        double Qa = Math.Pow(10, Convert.ToInt32(lblRatingP1.Text) / 400);
                        double Qb = Math.Pow(10, Convert.ToInt32(lblRatingP2.Text) / 400);
                        double Ea = Qa / (Qa + Qb);
                        double Eb = Qb / (Qa + Qb);
                        double Sa;
                        double Sb;
                        double Raa;
                        double Rab;

                        if ((nudScoreP1.Value == -1 && nudScoreP2.Value == 0) || (nudScoreP1.Value == 0 && nudScoreP2.Value == -1))
                        {
                            Sa = Convert.ToDouble(nudScoreP1.Value / 1);
                            Sb = Convert.ToDouble(nudScoreP2.Value / 1);
                            if (nudScoreP1.Value == -1 && nudScoreP2.Value == 0)
                            {
                                Raa = Kvalue * (Sa - Ea);
                                Rab = 0;
                            }
                            else if (nudScoreP1.Value == 0 && nudScoreP2.Value == -1)
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

                        int NRa = Convert.ToInt32(Convert.ToInt32(lblRatingP1.Text) + Math.Ceiling(Raa));
                        int NRb = Convert.ToInt32(Convert.ToInt32(lblRatingP2.Text) + Math.Ceiling(Rab));

                        string query2 = "CALL UpdateElo(" + NRa + ", " + NRb + ", '" + lblTagP1.Text + "', '" + lblTagP2.Text + "');";

                        commandDatabase.CommandText = query2;

                        databaseConnection.Open();
                        reader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Se ha actualiza los rating correctamente");
                        databaseConnection.Close();
                       
                    }
                    else
                    {
                        eloRecalc.RecalculateEloForUpdate(idt,idMatch,lastmatch,Kvalue,true);
                    }
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres borrar a este set?", "borrar set", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "CALL DeletMatch(" + idMatch + ");";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    MessageBox.Show("set borrado correctamente");
                    this.Close();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSet_Load(object sender, EventArgs e)
        {
            GetMatchData();
        }

        private void nudScoreP1_ValueChanged(object sender, EventArgs e)
        {
            if (nudScoreP1.Value == ogscore1 && nudScoreP2.Value == ogscore2)
            {
                btnEdit.Enabled = false;
            }else
            {
                btnEdit.Enabled = true;
            }
        }

        private void nudScoreP2_ValueChanged(object sender, EventArgs e)
        {
            if (nudScoreP1.Value == ogscore1 && nudScoreP2.Value == ogscore2)
            {
                btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
            }
        }

        private void lblRatingP2_Click(object sender, EventArgs e)
        {

        }
    }
}
