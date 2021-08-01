using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //abre la conexion de mysql
using System.Data;

namespace CapaModelo
{

    /*
     // obtener datos de una tabla CAPA MODELO

 public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM "+ tabla +"  ;";
OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
      */

    public class consultas
    {
        conexion con = new conexion();//instancia de conexion

        public DataTable llenarTbl()//metodo para obtener el contenido de una tabla
        {
            DataTable dTable = new DataTable();
            try
            {
                MySqlConnection conexion = con.abreConexion();//instancia de conexion
                
                string Query = "call consultaGen();";
                MySqlCommand MyCommand2 = new MySqlCommand(Query,conexion);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

            }
            catch(Exception e)
            {

            }


            return dTable;

            /*
             try
             {
                 int n = 0; //donde n es el numero de usuarios
                 string MyConnection2 = "datasource=localhost;port=3306;username=root;password=123456789;database=cineVision";
                 //Display query  

                 //conntar el numero de registros
                //n = SELECT COUNT(*) FROM usuarios;
                 string Query = "call consultaGen();";
                 MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                 MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                 //  MyConn2.Open();  
                 //For offline connection we weill use  MySqlDataAdapter class.  
                 MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                 MyAdapter.SelectCommand = MyCommand2;
                 DataTable dTable = new DataTable();
                 MyAdapter.Fill(dTable);
                 dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                    // MyConn2.Close();  
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }
             */


        }


    }
}
