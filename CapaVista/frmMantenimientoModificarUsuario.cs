using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CapaVista
{
    public partial class frmMantenimientoModificarUsuario : Form
    {
        public frmMantenimientoModificarUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = idUsuario.Text;
                string busqueda = "call verUser(2);";
                //recibi los datos y debe actualizar las textbox
                //de: nombreUsuario y passwordUsuario
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                int cont = 0;
                while (MyReader2.Read())
                {
                    /*if (cont == 0)
                    {
                        nombreUsuario=MyReader2.
                    }*/
                    nombreUsuario=MyReader2[0].ToString();
                    passwordUsuario = MyReader2[1].ToString();
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
