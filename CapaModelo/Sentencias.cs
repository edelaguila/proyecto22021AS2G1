using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;


namespace CapaModelo
{
     public class Sentencias
    {
        conexion con = new conexion();

        // obtener datos de una tabla CAPA MODELO

        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "call consultaGen();";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.Conexion());
            return dataTable;
        }

        public bool ingreso(string nombre, string pass)
        {
            int i = 0;
            try
            {
                string cadena = "call ingUser('"+nombre+"','"+pass+"');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.Conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);
                
            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] busquedaIndividual(string idu)
        {
            string name="";
            string pass="";
            try
            {
                string busqueda = "call verUser("+idu+");";
                OdbcCommand busI = new OdbcCommand(busqueda, con.Conexion());
                //busI.ExecuteNonQuery();
                OdbcDataReader lector = busI.ExecuteReader();
                string tempo = "";
                //string[] resultado = new string[];
                while (lector.Read())
                {
                    tempo = "";
                    //Console.WriteLine("CustomerID={0}", lector[0]);
                    //resultado.Append(tempo);
                }
            }
            catch (OdbcException)
            {

            }


            return new[] {name,pass};
        }

    }
}
