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
    public partial class FrmTournament : Form
    {
        int idTournament, idRanking;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;Convert Zero Datetime=true;";
        DateTime TourneyDate;

        public FrmTournament(int idt, int idr)
        {
            InitializeComponent();
            idTournament = idt;
            idRanking = idr;
        }

        private void getTourneyInfo()
        {
            string query = "CALL GetTourneyInfo(" + idTournament + ");";

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
                        lblTitle.Text = reader.GetString(0);
                        lblNumPlayers.Text = reader.GetInt32(1).ToString();
                        lblNumMatches.Text = reader.GetInt32(2).ToString();
                        lblDateTourney.Text = reader.GetDateTime(3).ToString();
                        lblKvalue.Text = reader.GetInt32(4).ToString();
                        TourneyDate = reader.GetDateTime(3);
                    }
                }

                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (lblNumMatches.Text == "0")
            {
                btnBuscarMatch.Enabled = false;
            }else
            {
                btnBuscarMatch.Enabled = true;
            }
        }

        private void FrmTournament_Load(object sender, EventArgs e)
        {
            getTourneyInfo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewSet_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNewSet FrmNSet = new FrmNewSet(idTournament,Convert.ToInt32(lblKvalue.Text));
            FrmNSet.ShowDialog();
            this.Show();
            getTourneyInfo();
            
        }

        private void btnBuscarMatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSearchSet FrmSSet = new FrmSearchSet(idTournament);
            FrmSSet.ShowDialog();
            this.Show();
            getTourneyInfo();
        }

        private void btnElimT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres borrar el Torneo " + lblTitle.Text + "?", "borrar Torneo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "CALL DeleteTourney(" + idTournament + ");";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();

                    reader = commandDatabase.ExecuteReader();

                    databaseConnection.Close();

                    MessageBox.Show("Torneo Eliminado Correctamente");

                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnEditTourney_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEditTourney FrmET = new FrmEditTourney(idTournament, lblTitle.Text, TourneyDate, Convert.ToInt32(lblKvalue.Text), idRanking);
            FrmET.ShowDialog();
            this.Hide();
            getTourneyInfo();
        }
    }
}
