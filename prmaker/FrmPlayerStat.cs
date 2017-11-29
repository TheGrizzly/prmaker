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

        public void GetStats1()
        {
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
            
        }

        private void btnElim_Click(object sender, EventArgs e)
        {

        }

        private void FrmPlayerStat_Load(object sender, EventArgs e)
        {
            GetStats1();
        }
    }
}
