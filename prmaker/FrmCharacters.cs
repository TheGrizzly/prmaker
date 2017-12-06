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
    public partial class FrmCharacters : Form
    {
        public FrmCharacters()
        {
            InitializeComponent();
        }

        //variables globales
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";
        Regex regexItem = new Regex("^[a-zA-Z0-9 ]*$");

        private void getChars()
        {
            cboChars.Items.Clear();

            string query = "CALL AllCharacters;";

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
                    while (reader.Read())
                    {
                        if(reader.GetString(0)!="Sin Main")
                            cboChars.Items.Add(reader.GetString(0));
                    }
                    // se cierra la conexion con la base de datos
                    databaseConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCharacters_Load(object sender, EventArgs e)
        {
            getChars();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string viejoNombre = cboChars.SelectedItem.ToString();
            string NuevoNombre = Interaction.InputBox("Ingresa el Nuevo nombre para el personaje", "Editar Personaje", cboChars.SelectedItem.ToString());

            if (NuevoNombre == ""){
                MessageBox.Show("ingresa un valor valido");
            } else if (NuevoNombre == cboChars.SelectedItem.ToString()) {
                MessageBox.Show("es el mismo valor");
            } else {
                bool repetido = false;
                for(int i = 0; i < cboChars.Items.Count; i++){
                    cboChars.SelectedIndex = i;
                    if (NuevoNombre == cboChars.SelectedItem.ToString())
                        repetido = true;
                }
                if (!regexItem.IsMatch(NuevoNombre))
                {
                    MessageBox.Show("Solo letras y Numeros");
                }else if (repetido){
                    MessageBox.Show("ya existe un personaje con ese nombre");
                }else{
                    string query = "CALL UpdateChar('"+NuevoNombre+"','"+viejoNombre+"');";

                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;

                    try
                    {
                        // se hace la conncecion a la base de datos y se saca los datos
                        databaseConnection.Open();

                        reader = commandDatabase.ExecuteReader();

                        MessageBox.Show("se ha actualizado correctamente");

                        databaseConnection.Close();
                        getChars();
                        btnEditar.Enabled = false;
                        btnElim.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void cboChars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChars.SelectedIndex == -1){
                btnElim.Enabled = false;
                btnEditar.Enabled = false;
            }else{
                btnEditar.Enabled = true;
                btnElim.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string NewChar = txtChar.Text;
            bool repetido = false;

            for (int i = 0; i < cboChars.Items.Count; i++)
            {
                cboChars.SelectedIndex = i;
                if (NewChar == cboChars.SelectedItem.ToString())
                    repetido = true;
            }

            if (NewChar == "")
            {
                MessageBox.Show("Ingrese un valor");
            }
            else if (repetido)
            {
                MessageBox.Show("Elemento Repetido");
            }
            else if (NewChar == "Sin Main")
                MessageBox.Show("Nombre Restrigido");
            else
            {
                string query = "CALL NewChar('" + NewChar + "');";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    MessageBox.Show("Personaje añadido correctamente");

                    databaseConnection.Close();

                    txtChar.Text = "";
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnElim.Enabled = false;
                    getChars();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres borrar a "+cboChars.SelectedItem.ToString()+"?", "borrar personaje", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                string query = "CALL DeleteCharWithName('"+cboChars.SelectedItem.ToString()+"');";

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
                    getChars();
                    btnEditar.Enabled = false;
                    btnElim.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }

        private void txtChar_TextChanged(object sender, EventArgs e)
        {
            if (!regexItem.IsMatch(txtChar.Text))
            {
                btnNuevo.Enabled = false;
            }else
            {
                btnNuevo.Enabled = true;
            }
        }
    }
}
