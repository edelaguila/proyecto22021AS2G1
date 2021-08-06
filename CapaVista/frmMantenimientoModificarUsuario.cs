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
    public partial class frmMantenimientoModificarUsuario : Form
    {
        controlador cn = new controlador();
        public frmMantenimientoModificarUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //buscqueda individual para traer los datos del ususario seleccionado
            string uid = txtId.Text;
            var lista = cn.busquedaIndividual(uid);
            txtNom.Text =(string) lista[0];
            txtPass.Text = (string)lista[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //modificacion de los datos del usuario
            string mnsj="¿Desea actualizar a este usuario?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if(resultado == System.Windows.Forms.DialogResult.Yes)
            {
                //ejecutar actualizacion

                MessageBox.Show("Id de Usuario "+txtId.Text+" actualizada");
            }
            else
            {
                MessageBox.Show("No se actualizará al usuario "+txtId.Text);
            }
            txtId.Text = "";
            txtNom.Text = "";
            txtPass.Text = "";
        }
    }
}
