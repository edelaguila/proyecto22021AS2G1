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
    public partial class frmEdiciónCartelera : Form
    {
        public frmEdiciónCartelera()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frmEA = new frmElecciónAdmin();
            frmEA.Show();
            this.Close();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            var frmEA = new frmMantenimientoDePeliculas();
            frmEA.Show();
            this.Hide();
        }

        private void btnDerechos_Click(object sender, EventArgs e)
        {
            var frmID = new frmIngresoDerechos();
            frmID.Show();
            this.Hide();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            var frmH = new frmHorarios();
            frmH.Show();
            this.Hide();
        }
    }
}
