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
            //btnEliminar
            string mnsj = "¿Desea eliminar el privilegio con id: " + txtIdPriv.Text + " ?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                //ejecutar actualizacion
                string idPriv = txtIdPriv.Text;
                
                bool result = cn.elPriv(idPriv);
                if (result)
                {
                    MessageBox.Show("Privilegio eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("No se logro eliminar el privilegio");
                }

                txtIdPriv.Text = "";
                consulta();
            }
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
            var privs = cn.privilegios();

            for (int i = 0; i < privs.Count; i++)
            {
                tipoPriv.Items.Add(privs[i].ToString());
            }
        }

        private void consulta()
        {
            string id = txtId.Text;
            var lista = cn.busquedaIndividual(id);
            txtUser.Text = (string)lista[0];

            //la consulta para la tabla
            DataTable dt = cn.llenarTblPrivUser(id);
            listaUsuPriv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaUsuPriv.DataSource = dt;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*//la consulta para el name
            string id = txtId.Text;
            var lista = cn.busquedaIndividual(id);
            txtUser.Text = (string)lista[1];

            //la consulta para la tabla
            DataTable dt = cn.llenarTblPrivUser(id);
            listaUsuPriv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaUsuPriv.DataSource = dt;*/
            consulta();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string mnsj = "¿Desea dar este privilegio "+tipoPriv.Text+", a este usuario "+txtUser.Text+" ?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                //ejecutar actualizacion
                string idU = txtId.Text;
                //string idP = txtIdTipo.Text;
                int id;
                id = (tipoPriv.SelectedIndex + 1);
                string idP = id + "";
                bool result= cn.ingPriv(idU,idP);
                if (result)
                {
                    MessageBox.Show("Privilegio otorgado correctamente");
                }
                else
                {
                    MessageBox.Show("No se logro otorgar el privilegio");
                }
                
                txtIdPriv.Text = "";
                consulta();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tipoPriv_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int id;
            id = (tipoPriv.SelectedIndex+1);
            txtIdTipo.Text = id+"";*/
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            string mnsj = "¿Desea modificar el privilegio con id: "+txtIdPriv.Text +" por este otro:"+ tipoPriv.Text +" ?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                //ejecutar actualizacion
                string idPriv = txtIdPriv.Text;
                //string idP = txtIdTipo.Text;
                int id;
                id = (tipoPriv.SelectedIndex + 1);
                string idP = id + "";
                bool result = cn.modifPriv(idPriv, idP);
                if (result)
                {
                    MessageBox.Show("Privilegio modificado correctamente");
                }
                else
                {
                    MessageBox.Show("No se logro modificar el privilegio");
                }

                txtIdPriv.Text = "";
                consulta();
            }
        }
        
    }
}
