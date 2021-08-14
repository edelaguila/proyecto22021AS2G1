using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmConsultaHorario : Form
    {
        controlador cn = new controlador();
        public frmConsultaHorario()
        {
            InitializeComponent();
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            var frmH = new frmHorarios();
            frmH.Show();
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable data = cn.llenarTblPeliHorario();
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.DataSource = data;
        }
    }
}
