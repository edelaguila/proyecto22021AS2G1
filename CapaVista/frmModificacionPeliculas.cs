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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nom = txtNom.Text;
            string clasif = cmbClasi.Text;
            string gen = cmbGenero.Text;
            string sub = cmbSub.Text;
            string idim = txtIdioma.Text;
            string preci = txtPrecio.Text;
            string sinop = rtxtSinop.Text;

            string mnsj = "¿Desea actualizar a esta película?";
            string titulo = "Confirmación";

            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                bool result = cn.actuPelis(id, nom, clasif, gen, sub, idim, preci, sinop);
                if (result)
                {
                    MessageBox.Show("Modificación correcta");
                }
                else
                {
                    MessageBox.Show("Modificación fallida");
                }
                txtId.Text = "";
                txtNom.Text = "";
                txtIdioma.Text = "";
                txtPrecio.Text = "";
                rtxtSinop.Text = "";
                dgvAct.DataSource =null;
            }

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            var frmMan = new frmMantenimientoDePeliculas();
            frmMan.Show();
            this.Close();
        }
    }
}
