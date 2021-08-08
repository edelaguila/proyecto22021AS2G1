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
    public partial class frmHorarios : Form
    {
        public frmHorarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            var frmEA = new frmEdiciónCartelera();
            frmEA.Show();
            this.Close();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            var frmIH = new frmIngresoHorario();
            frmIH.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var frmMH = new frmModificacionHorario();
            frmMH.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var frmEH = new frmEliminacionHorario();
            frmEH.Show();
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var frmCH = new frmConsultaHorario();
            frmCH.Show();
            this.Close();
        }
    }
}
