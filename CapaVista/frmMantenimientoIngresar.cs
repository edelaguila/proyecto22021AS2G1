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
using System.Data.Odbc;

namespace CapaVista
{
    public partial class insertarUsuario : Form
    {
        controlador nuevoCn = new controlador();

        
        public insertarUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string nombre = txtNom.Text;
            string password = txtPass.Text;

            MessageBox.Show(""+nombre);
            MessageBox.Show(""+password);

            bool resultado = nuevoCn.ingreso(nombre, password);
            if (resultado)
            {
                MessageBox.Show("Consulta correcta");
            }
            else
            {
                MessageBox.Show("Consulta erronea");
            }*/
            OdbcConnection conn = new OdbcConnection("Dsn=conexion");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }

            try
            {
                string cadena = "call ingUser('" + txtNom.Text + "','" + txtPass.Text + "');";

                OdbcCommand ingreso = new OdbcCommand(cadena, conn);
                ingreso.ExecuteNonQuery();
               
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);

            }
        }
    }
}
