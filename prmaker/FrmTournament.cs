using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prmaker
{
    public partial class FrmTournament : Form
    {
        int idTournament;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prmaker;";

        public FrmTournament(int idt)
        {
            InitializeComponent();
            idTournament = idt;
        }

        private void FrmTournament_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
