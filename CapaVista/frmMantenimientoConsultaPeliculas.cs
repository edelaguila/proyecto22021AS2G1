using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmMantenimientoConsultaPeliculas : Form
    {
        controlador cn = new controlador();
        public frmMantenimientoConsultaPeliculas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //buscqueda individual para traer los datos del ususario seleccionado
            string uid = txtId.Text;
            var lista = cn.busquedaIndividualPelis(uid);
            txtNom.Text = (string)lista[0];

           
            

            

            //byte [] MisDatos= new byte[0];
            //MemoryStream ms = new MemoryStream(MisDatos);
            
           

        }
    }
}
