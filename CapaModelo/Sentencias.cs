using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Collections;

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
                string cadena = "call ingUser('" + nombre + "','" + pass + "');";
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

        public ArrayList busquedaIndividual(string idu)
        {
            var arList = new ArrayList();
            try
            {
                string busqueda = "call verUser(" + idu + ");";
                OdbcCommand busI = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    arList.Add(lector[0]);
                    arList.Add(lector[1]);
                    arList.Add(lector[2]);
                }
            }
            catch (OdbcException)
            {

            }


            return arList;
        }

        public bool actuUsuario(string id, string nombre, string pass)
        {
            int i = 0;
            try
            {
                string cadena = "call actuUser('" + nombre + "','" + pass + "',"+id+");";
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

        public bool deleteUser(string id)
        {
            int i = 0;
            try
            {
                string cadena = "call bajaUser("+ id + ");";
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

        public ArrayList busquedaCiudad()
        {
            var arList = new ArrayList();
            try
            {
                string busqueda = "call consultaGenCiudad();";
                OdbcCommand busI = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())//en toeria esta recorrera todos los registros
                {
                    //arList.Add(lector[0]);//idciudad
                    arList.Add(lector[1]);//nombre ciudad
                   

                    //arList.Add(lector[2]);//foraneo con cine
                }
            }
            catch (OdbcException)
            {

            }


            return arList;//retornara el nombre de todos los cines en el arrayList
        }
        public OdbcDataAdapter llenarTblPriv()// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "call consultaPriv();";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.Conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblPrivUser(string id)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "call privilegiosUsuarios("+id+");";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.Conexion());
            return dataTable;
        }
    }
}
