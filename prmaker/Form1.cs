﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;


namespace prmaker
{
    public partial class FrmMenu : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";

        //constructor
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            // se hace la conneccion a la base de datos
            
            string query = "CALL ShowRankings;";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // se hace una consulta con todos los rankings y le meto los valores a cboRankings
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] rankings = { reader.GetString(0) };
                        cboRankngs.Items.Add(reader.GetString(0));
                    }
                }
                // se cierra la conexion con la base de datos
                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // cuento el numero de rankings, si hay mas de 1 habilito cboRankngs
            var count = cboRankngs.Items.Count;

            if (count == 0)
            {
                cboRankngs.Enabled = false;
            }
            else
                cboRankngs.Enabled = true;
        }

        private void btnNewRank_Click(object sender, EventArgs e)
        {
            // pido el nombre del nuevo ranking
            string RankingName = Interaction.InputBox("Ingrese el nombre del nuevo ranking", "Nuevo Ranking", "Ranking Nuevo");

            var count = cboRankngs.Items.Count;
            bool repetido = false;

            //comparo con el nombre del nuevo ranking con los anteriores para no tener repetidos
            for(int i=0; i<count; i++)
            {
                cboRankngs.SelectedIndex = i;
                if(cboRankngs.SelectedItem.Equals(RankingName))
                {
                    repetido = true;
                }
            }

            if (repetido)
            {
                MessageBox.Show("Ya existe un ranking con ese nombre, eliga otro nombre");
            }else if(RankingName.Length >30)
            {
                MessageBox.Show("nombre no valido, mas corto");
            }
            else
            {
                //creo el query y la conexion con la base de datos
                string query = "CALL NewRanking('"+RankingName+"');";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    //ejecuto el insert, y muestro la venta FrmRanking
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    MessageBox.Show("Ranking Creado correctamente");

                    databaseConnection.Close();

                    Form ranking = new FrmRanking(RankingName);
                    ranking.Text = RankingName;

                    this.Hide();

                    ranking.ShowDialog();

                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void cboRankngs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // si cambia el valor de cboRank habilito el boton de cargar un ranking
            btnLoadRank.Enabled = true;
        }

        private void btnLoadRank_Click(object sender, EventArgs e)
        {
            //cambio el nombre de la ventana por el valor seleccionado en CboRankngs y muestro FrmRankings
            Form ranking = new FrmRanking(cboRankngs.SelectedItem.ToString());
            ranking.Text = cboRankngs.SelectedItem.ToString();

            this.Hide();

            ranking.ShowDialog();

            this.Show();
        }
    }
}