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
    public partial class FrmNewTourney : Form
    {

        int idRanking;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        List<string> tourneyNames = new List<string>();

        public FrmNewTourney(int idr, List<string> tn)
        {
            InitializeComponent();
            idRanking = idr;
            tourneyNames = tn;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            if (tourneyNames.Count == 0)
            {
                btnNew.Enabled = true;
            }
            else
            {
                for (int i = 0; i < tourneyNames.Count; i++)
                {
                    if (txtTName.Text == tourneyNames[i])
                    {
                        btnNew.Enabled = false;
                        break;
                    }
                    else
                    {
                        btnNew.Enabled = true;
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string query = "CALL NewTourney('" + txtTName.Text + "', " + nudKvalue + ", " + dtpTourneyDate.Value + ", " + idRanking + ");";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                databaseConnection.Close();

                MessageBox.Show("Torneo creado correctamente");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmNewTourney_Load(object sender, EventArgs e)
        {
            
        }
    }
}
