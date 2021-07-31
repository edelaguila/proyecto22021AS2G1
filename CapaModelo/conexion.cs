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


        public void cierraConexion(MySqlConnection cerrar)
        {
            try
            {
                cerrar.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("No se logro cerrar la conexion");
            }

        }
    }
}
