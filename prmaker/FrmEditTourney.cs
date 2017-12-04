using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace prmaker
{
    public partial class FrmEditTourney : Form
    {
        int idRanking;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;Convert Zero Datetime=true;";
        int idTournament, kvalue;
        string Tname;
        DateTime TDate;
        List<string> tourneyNames = new List<string>();
        Regex regexItem = new Regex("^[a-zA-Z0-9 ]*$");

        public void GetTNames()
        {
            string query = "CALL GetTNames(" + idRanking + ");";

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
                        tourneyNames.Add(reader.GetString(0));
                    }
                }

                databaseConnection.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FrmEditTourney(int idt, string nameT, DateTime dateT, int kvalueT, int idr)
        {
            InitializeComponent();
            idTournament = idt;
            Tname = nameT;
            TDate = dateT;
            kvalue = kvalueT;
            idRanking = idr;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTName_TextChanged(object sender, EventArgs e)
        {
            if (dtpTourneyDate.Value == TDate && txtTName.Text == Tname)
            {
                btnNew.Enabled = false;
            }
            else if (!regexItem.IsMatch(txtTName.Text) || txtTName.Text=="")
            {
                btnNew.Enabled = false;
            }
            else if (tourneyNames.Count == 0)
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

        private void nudKvalue_ValueChanged(object sender, EventArgs e)
        {
            if(dtpTourneyDate.Value==TDate && txtTName.Text == Tname)
            {
                btnNew.Enabled = false;
            }else
            {
                btnNew.Enabled = false;
            }
        }

        private void dtpTourneyDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTourneyDate.Value == TDate && txtTName.Text == Tname)
            {
                btnNew.Enabled = false;
            }
            else
            {
                btnNew.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string query = "CALL EditTourney(" + idTournament + ", '" + txtTName.Text + "', '" + dtpTourneyDate.Value + "');";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("base de datos actualizada correctamente");
                databaseConnection.Close();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmEditTourney_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Tname;
            lblKv.Text = kvalue.ToString();
            dtpTourneyDate.Value = TDate;
            txtTName.Text = Tname;
            GetTNames();
        }
    }
}
