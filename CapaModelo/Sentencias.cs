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
                Console.WriteLine("Error al actualizar " + Error);

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
                Console.WriteLine("Error al dar de baja " + Error);

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

        public ArrayList busquedaCine()
        {
            var arList = new ArrayList();
            try
            {

                string busqueda = "call consultaGenCine();";//select 
                //procedure
                //triger
                OdbcCommand busI = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())//en toeria esta recorrera todos los registros
                {

                   
                    //arList.Add(lector[0]);//idciudad
                    arList.Add(lector[1]+"   "+lector[2]);//nombre ciudad
                   // arList.Add(lector[2]);//Dirección
                }
            }
            catch (OdbcException)
            {

            }


            return arList;//retornara el nombre de todos los cines en el arrayList
        }
        /*public OdbcDataAdapter llenarTblPriv()// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "call consultaPriv();";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.Conexion());
            return dataTable;
        }*/



        public OdbcDataAdapter llenarTblPrivUser(string id)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "call privilegiosUsuarios("+id+");";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.Conexion());
            return dataTable;
        }

        public bool ingPriv(string idU, string idP)
        {
            int i = 0;
            try
            {
                string cadena = "call ingPrivUs("+idU + "," + idP + ");";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.Conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar privilegio" + Error);

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

        public ArrayList privilegios()
        {
            var arList = new ArrayList();
            try
            {
                string busqueda = "call  consultaPriv();";
                OdbcCommand busI = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    arList.Add(lector[1]);
                }
            }
            catch (OdbcException)
            {

            }
            return arList;
        }

        public bool modifPriv(string idPriv, string idP)
        {
            int i = 0;
            try
            {
                string cadena = "call modifPrivUs(" + idPriv + "," + idP + ");";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.Conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al modificar privilegio" + Error);

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

        public bool elPriv(string idPriv)
        {
            int i = 0;
            try
            {
                string cadena = "call elPrivUs(" + idPriv + ");";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.Conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al eliminar el privilegio" + Error);

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

        public bool iniciaSesion(string usuario, string pass)
        {
            bool coincidencia = false;

            var dataLogin = new ArrayList();
            string userDB = "";
            string passDB = "";
            try
            {

                string busqueda = "call login('"+usuario+"','"+pass+"');";
                OdbcCommand iSesion = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = iSesion.ExecuteReader();
                while (lector.Read())
                {
                    dataLogin.Add(lector[0]);
                    dataLogin.Add(lector[1]);

                }

                int i = dataLogin.Count;

                if (!(i < 2))
                {
                    userDB = (string)dataLogin[0];
                    passDB = (string)dataLogin[1];
                    if (usuario == userDB && pass == passDB)
                    {
                        coincidencia = true;
                    }
                }
            }
                
            catch (OdbcException)
            {

            }

            return coincidencia;
        }
    }
}
