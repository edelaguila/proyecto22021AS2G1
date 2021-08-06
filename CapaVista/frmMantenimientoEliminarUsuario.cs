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
using System.Collections;

namespace CapaVista
{
    public partial class frmMantenimientoEliminarUsuario : Form
    {
        controlador cn = new controlador();
        public frmMantenimientoEliminarUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string uid = txtId.Text;
            var lista = cn.busquedaIndividual(uid);
            txtNom.Text = (string)lista[0];
            Int16 estado = (Int16)lista[2];

            txtEstado.Text = ""+estado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //deleteo de los datos del usuario
            string mnsj = "¿Desea eliminar a este usuario?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                //ejecutar eliminación
                string id = txtId.Text;



                bool result = cn.deleteUser(id);
                if (result)
                {
                    MessageBox.Show("Eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("Eliminación fallida");
                }
                txtNom.Text = "";
                txtEstado.Text = "";
              
            }
        }
    }
}
