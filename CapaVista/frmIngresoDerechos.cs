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
    public partial class frmIngresoDerechos : Form
    {
        controlador cn = new controlador();
        public frmIngresoDerechos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            var frmEC = new frmEdiciónCartelera();
            frmEC.Show();
            this.Hide();
        }
        private void cargaPelis()
        {
            cmbPeli.Items.Clear();
            cmbPeli.DropDownStyle = ComboBoxStyle.DropDownList;
            var listaPeli = cn.busquedaPeliD();
            for (int i = 0; i < listaPeli.Count; i++)
            {
                cmbPeli.Items.Add(listaPeli[i].ToString());
            }
        }

        private void frmIngresoDerechos_Load(object sender, EventArgs e)
        {
            cargaPelis();
        }

        private void cmbPeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pelid =cmbPeli.SelectedIndex+1;
            string peliid = pelid + "";

            DataTable dt = cn.llenarTblPeliD(peliid);
            dgvDatospeli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatospeli.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pelid = cmbPeli.SelectedIndex + 1;
            string peliid = pelid + "";
            string mnsj = "¿Desea eliminar a esta película?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                bool result = cn.elimPeliD(peliid);
                if (result)
                {
                    MessageBox.Show("Los derechos de la película fue dada de baja");
                }
                else
                {
                    MessageBox.Show("No se logro dar de baja los derechos");
                }
                dgvDatospeli.DataSource = null;
                cargaPelis();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            int pelid = cmbPeli.SelectedIndex + 1;
            string peliid = pelid + "";
            string mnsj = "¿Desea dar de alta a esta película?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                bool result = cn.altaPeliD(peliid);
                if (result)
                {
                    MessageBox.Show("Los derechos de la película fueron dados de alta");
                }
                else
                {
                    MessageBox.Show("No se logro dar de alta los derechos");
                }
                dgvDatospeli.DataSource = null;
                cargaPelis();
            }
        }
    }
}
