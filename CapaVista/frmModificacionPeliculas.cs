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
    public partial class frmModificacionPeliculas : Form
    {
        controlador cn = new controlador();
        public frmModificacionPeliculas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            DataTable dt = cn.llenarTblPeliInd(id);
            dgvAct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAct.DataSource = dt;

        }
    }
}
