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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmMU = new frmMantenimientoModificarUsuario();
            frmMU.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmC = new frmMantenimientoConsultaGeneralUsuarios();
            frmC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frmElim = new frmMantenimientoEliminarUsuario();
            frmElim.Show();
        }
    }
}
