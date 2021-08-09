using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMantenimientoDePeliculas : Form
    {
        public frmMantenimientoDePeliculas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            var frmEA = new frmEdiciónCartelera();
            frmEA.Show();
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var frmEA = new frmConsultaPeliculas();
            frmEA.Show();
            this.Hide();
        }
    }
}
