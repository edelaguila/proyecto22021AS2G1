using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //clase para usar var
using CapaControlador;

namespace CapaVista
{
    public partial class frmSelecciónCine : Form
    {

        controlador cn = new controlador();
        public frmSelecciónCine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) /*boton ver cartelera*/
        {
            //var frmMU = new frmCartelera();
            // frmMU.Show();
            //this.Close();

            var listaCines = cn.busquedaCiudad();//tengo la lista de las ciudades


            //convertir a string
            // txtNom.Text = (string)lista[0];


            //intento de recorrer todo el arralist
            for (int i = 0; i < listaCines.Count; i++)
            {
                comboBox1.Items.Add(listaCines[i].ToString());
            }
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            var frmME = new frmMenuEntrada();
            frmME.Show();
            this.Close();
        }
    }
}
