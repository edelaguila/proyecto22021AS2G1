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
using System.Data;

namespace CapaVista
{
    public partial class frmAdminUsuarios : Form
    {
        controlador cn = new controlador();
        public frmAdminUsuarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegrear_Click(object sender, EventArgs e)
        {
            var frmEA = new frmElecciónAdmin();
            frmEA.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminUsuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = cn.llenarTblPriv();
            tiposPriv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tiposPriv.DataSource = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //la consulta para el name
            string id = txtId.Text;
            var lista = cn.busquedaIndividual(id);
            txtUser.Text = (string)lista[1];

            //la consulta para la tabla
            DataTable dt = cn.llenarTblPrivUser(id);
            listaUsuPriv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaUsuPriv.DataSource = dt;
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string mnsj = "¿Desea dar este privilegio "+txtIdTipo.Text+", a este usuario "+txtUser.Text+" ?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                //ejecutar actualizacion
                string idU = txtId.Text;
                string idP = txtIdTipo.Text;


                bool result= cn.ingPriv(idU,idP);
                if (result)
                {
                    MessageBox.Show("Privilegio otorgado correctamente");
                }
                else
                {
                    MessageBox.Show("No se logro otorgar el privilegio");
                }
                txtIdTipo.Text = "";
                txtIdPriv.Text = "";

            }
        }
    }
}
