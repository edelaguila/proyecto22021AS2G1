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
    public partial class frmEliminacionPeli : Form
    {
        controlador cn = new controlador();
        public frmEliminacionPeli()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            var frmMan = new frmMantenimientoDePeliculas();
            frmMan.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            DataTable dt = cn.llenarTblPeliInd(id);
            dgvAct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAct.DataSource = dt;
        }

        private void btnEliminacion_Click(object sender, EventArgs e)
        {
            string mnsj = "¿Desea eliminar a esta película?";
            string titulo = "Confirmación";
            string id = txtId.Text;
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                bool result = cn.elimPelis(id);
                if (result)
                {
                    MessageBox.Show("La película fue dada de bajo");
                }
                else
                {
                    MessageBox.Show("No se logro dar de baja");
                }
                txtId.Text = "";
                dgvAct.DataSource = null;
            }

        }
    }
}
