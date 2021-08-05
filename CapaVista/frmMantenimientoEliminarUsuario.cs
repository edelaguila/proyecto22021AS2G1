﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //Its for MySQL  
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
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=123456789;database=cinevision";
                string cod = idUsuario.Text;
                string busqueda = "call verUser("+cod+");";

                //recibi los datos y debe actualizar las textbox
                //de: nombreUsuario y passwordUsuario
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(busqueda, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                   nombre.Text = MyReader2[0].ToString();
                    estado.Text = MyReader2[1].ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, nos e pudo lograr la conexión");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {


                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=123456789;database=cinevision";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "call bajaUser(" + this.idUsuario.Text + "); ";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Informacion eliminada en la base de datos");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error no se pudo eliminar la informacion");
            }
        }
    }
}
