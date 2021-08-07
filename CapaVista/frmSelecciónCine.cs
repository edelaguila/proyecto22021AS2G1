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
            var frmMU = new frmCartelera();
            frmMU.Show();
            this.Close();


        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            var frmME = new frmMenuEntrada();
            frmME.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSelecciónCine_Load(object sender, EventArgs e)
        {

            //bloqueo combobox
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            var listaCines = cn.busquedaCine();//tengo la lista de las ciudades


            //convertir a string
            // txtNom.Text = (string)lista[0];


            //intento de recorrer todo el arralist
            for (int i = 0; i < listaCines.Count; i++)
            {
                comboBox1.Items.Add(listaCines[i].ToString());
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
