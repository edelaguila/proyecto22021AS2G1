using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Collections;
using System.IO;

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
                // call ingUser('Noel','123456');
                // call consultGen();
                // call conInd(1);
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
            Int16 estado = 0;

            try
            {

                string busqueda = "call login('"+usuario+"','"+pass+"');";
                OdbcCommand iSesion = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = iSesion.ExecuteReader();
                while (lector.Read())
                {
                    dataLogin.Add(lector[0]);
                    dataLogin.Add(lector[1]);
                    dataLogin.Add(lector[2]);
                }

                int i = dataLogin.Count;

                if (!(i < 3))
                {
                    userDB = (string)dataLogin[0];
                    passDB = (string)dataLogin[1];
                    estado = (Int16)dataLogin[2];
                    if (usuario == userDB && pass == passDB && estado==1)
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


        //metodo parafiltra peliculas 
        public ArrayList busquedaFiltraPelis()
        {

            //todos los Arraylist
            var arID = new ArrayList();
            var arNom = new ArrayList();
            var arCla = new ArrayList();
            var arGen = new ArrayList();
            var arSub = new ArrayList();
            var arIdioma = new ArrayList();
            var arPrecio = new ArrayList();

            var arList = new ArrayList();
            try
            {

                string busqueda = "call consultaFiltraPelis();";//select 
                //procedure
                //triger
                OdbcCommand busI = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())//en toeria esta recorrera todos los registros
                {

                    //proceso
                    arID.Add(lector[0]);//ID
                    arNom.Add(lector[1]);//Nombre
                    arCla.Add(lector[2]);//Clasificación
                    arGen.Add(lector[3]);//Genero
                    arSub.Add(lector[4]);//Subtitulado
                    arIdioma.Add(lector[5]);//Idioma
                    arPrecio.Add(lector[6]);//Precio

                   
                }
            }
            catch (OdbcException)
            {

            }


            arID.Add(arID);
            arID.Add(arNom);
            arID.Add(arCla);
            arID.Add(arGen);
            arID.Add(arSub);
            arID.Add(arIdioma);
            arID.Add(arPrecio);

            /*
             DELIMITER |
CREATE PROCEDURE consultaFiltraPelis()
BEGIN
	select idPeliculas as ID, Nombre, Clasificación, Genero, Subtitulado, Idioma, precio from peliculas;
END
| 

call consultaFiltraPelis();
drop consultaFiltraPelis;
select *from peliculas;

insert into peliculas values (1,'avengers','Adultos','peleas','No','latino',400);
insert into peliculas values (2,'Dragon ball super broly','T','peleas','No','latino',500);
             */



            return arList;//retorna toda la infomración nencesara para la caterlera
        }


        //metodo de ingreso de peliculas

        public bool ingresoPeliculas(string nom, string clas, string gen, string sub, string idio, string preci, string sinop, object imagen)
        {
            int i = 0;
            try
            {
                string cadena = "call insertPeli('"+nom+"','"+clas+"','"+gen+"','"+sub+"','"+idio+"','"+preci+"','"+sinop+ "','" + imagen + "'); ";

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


        public ArrayList busquedaIndividualPelis(string idu)
        {
            var arList = new ArrayList();
            try
            {
                string busqueda = "select imagen from peliculas where idPeliculas=12;";
                OdbcCommand busI = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = busI.ExecuteReader();

               

             
               
                


                while (lector.Read())
                {
                    arList.Add(lector[0]);
                    
                }
            }
            catch (OdbcException)
            {

            }


            return arList;
        }






        public OdbcDataAdapter llenarTblPeli()
        {
            string sql = "call consultaGenpelis ();";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.Conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblPeliInd(string id)
        {
            string sql = "call consultaIndPeli("+id+");";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.Conexion());
            return dataTable;
        }

        public bool actuPelis(string id, string nom, string clasif, string gen, string sub, string idim, string preci, string sinop)
        {
            int i = 0;
            try
            {
                string cadena = "call actuPelis(" + id + ",'" + nom + "','"+clasif+"','"+gen+"','"+sub+"','"+idim+"','"+preci+"','"+sinop+"');";
                OdbcCommand modif = new OdbcCommand(cadena, con.Conexion());
                modif.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al modificar película" + Error);

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

        public bool elimPelis(string id)
        {
            int i = 0;
            try
            {
                string cadena = "call elimPelis("+ id +");";
                OdbcCommand modif = new OdbcCommand(cadena, con.Conexion());
                modif.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al eliminar la película" + Error);

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

        
        public ArrayList busquedaPeliD()
        {
            var arList = new ArrayList();
            try
            {

                string busqueda = "call consultaDerechosPeli();";//select 
                //procedure
                //triger
                OdbcCommand busI = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())//en toeria esta recorrera todos los registros
                {


                    //arList.Add(lector[0]);//idciudad
                    arList.Add(lector[0] + "   " + lector[1]+" "+lector[2]);//nombre ciudad
                                                              // arList.Add(lector[2]);//Dirección
                }
            }
            catch (OdbcException)
            {

            }


            return arList;//retornara el nombre de todos los cines en el arrayList
        }

        
        public OdbcDataAdapter llenarTblPeliD(string peliid)
        {
            string sql = "call consultaDP(" + peliid+");";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.Conexion());
            return dataTable;
        }

        public bool elimPeliD(string id)
        {
            int i = 0;
            try
            {
                string cadena = "call elimPeliD(" + id + ");";
                OdbcCommand modif = new OdbcCommand(cadena, con.Conexion());
                modif.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al eliminar los derehcos de la película" + Error);

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

        public bool altaPeliD(string id)
        {
            int i = 0;
            try
            {
                string cadena = "call altaPeliD(" + id + ");";
                OdbcCommand modif = new OdbcCommand(cadena, con.Conexion());
                modif.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al dar de alta los derehcos de la película" + Error);

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

        public bool ingresoHorario(string fechahora)
        {
            int i = 0;
            try
            {
                string cadena = "call ingresoHorario('" + fechahora + "');";
                OdbcCommand ingh = new OdbcCommand(cadena, con.Conexion());
                ingh.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error, no se pudo ingresar el horario\n" + Error);

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

        public ArrayList busquedaPeli()
        {
            var arList = new ArrayList();
            try
            {
                string busqueda = "call consultaGenPelis();";
                OdbcCommand busI = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    arList.Add(lector[0] + " -  " + lector[1]);
                }
            }
            catch (OdbcException)
            {

            }
            return arList;
        }

        public ArrayList busquedaSala()
        {
            var arList = new ArrayList();
            try
            {
                string busqueda = "call consultaSala();";
                OdbcCommand busI = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    arList.Add("("+lector[0]+")" + lector[1]+": "+lector[2]+" Cine: "+lector[3]+", "+lector[4]);
                }
            }
            catch (OdbcException)
            {

            }
            return arList;
        }

        public ArrayList busquedaHorario()
        {
            var arList = new ArrayList();
            try
            {
                string busqueda = "select * from horarios;";
                OdbcCommand busI = new OdbcCommand(busqueda, con.Conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    arList.Add("(" + lector[0] + ") " + lector[1]);
                }
            }
            catch (OdbcException)
            {

            }
            return arList;
        }

        public bool ingHorarioPeli(string peli, string sala, string horario)
        {
            int i = 0;
            try
            {
                string cadena = "call ingHorarioCi(" + peli + ","+sala+","+horario+");";
                OdbcCommand ingh = new OdbcCommand(cadena, con.Conexion());
                ingh.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error, no se pudo asignar el horario a la pelicula seleccionada\n" + Error);

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
        public OdbcDataAdapter llenarTblPeliHorario()
        {
            string sql = "call conGenHorarioCi();";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.Conexion());
            return dataTable;
        }

        public OdbcDataAdapter consultaIndHorariCi(string id)
        {
            string consulta = "call conIndHorarioCi("+id+");";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(consulta, con.Conexion());
            return dataTable;
        }

        public bool modifHorarioPeli(string peli, string sala, string horario, string id)
        {
            int i = 0;
            try
            {
                string cadena = "call modifHorarioCi(" + peli + "," + sala + "," + horario + ","+id+");";
                OdbcCommand ingh = new OdbcCommand(cadena, con.Conexion());
                ingh.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error, no se pudo modificar el horario de la peli\n" + Error);

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

        public bool elimHorarioPeli(string id)
        {
            int i = 0;
            try
            {
                string cadena = "call bajaHorarioCin(" + id + ");";
                OdbcCommand ingh = new OdbcCommand(cadena, con.Conexion());
                ingh.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error, no se pudo eliminar el horario de la peli\n" + Error);

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
    }

}
