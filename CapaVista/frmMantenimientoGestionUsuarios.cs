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
    public partial class frmMantenimientoGestionUsuarios : Form
    {
        public frmMantenimientoGestionUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmMGU = new frmIngresoUsuario();
            frmMGU.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmMU = new frmMantenimientoModificarUsuario();
            frmMU.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmC = new frmMantenimientoConsultaGeneralUsuarios();
            frmC.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frmElim = new frmMantenimientoEliminarUsuario();
            frmElim.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frmEA = new frmElecciónAdmin();
            frmEA.Show();
            this.Close();
        }
    }
}
