using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMantenimientoEliminarUsuario : Form
    {
        public frmMantenimientoEliminarUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = idUsuario.Text;
                string busqueda = "call verUser("+cod+");";

                //recibi los datos y debe actualizar las textbox
                //de: nombreUsuario y passwordUsuario
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    nombre.Text = MyReader2[0].ToString();
                    estado.Text = MyReader2[2].ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, nos e pudo lograr la conexión");
            }
        }
    }
}
