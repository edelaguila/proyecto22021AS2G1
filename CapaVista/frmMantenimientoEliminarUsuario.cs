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
            txtEstado.Text = (string)lista[2];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
