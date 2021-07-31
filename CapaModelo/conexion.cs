using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using MySql.Data.MySqlClient;  //abre la conexion de mysql

namespace CapaModelo
{
    class conexion
    { 
        //abre la conexion si es posible de lo controrario no lo abrir y no enviara nada

        public MySqlConnection abreConexion()
        {

            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=123456789;database=cinevision";
            //This is my insert query in which i am taking input from the user through windows forms  
            //string Query = "insert into usuarios(Usuario,Password) values('" + this.t1.Text + "','" + this.t2.Text + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            try
            {
                MyConn2.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("No se logro abrir la conexion");
            }

            return MyConn2;
        }
    }
}
