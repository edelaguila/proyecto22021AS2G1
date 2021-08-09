using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControlador;
using CapaModelo;
using System.Data;
using System.Data.Odbc;
using System.Collections;

namespace CapaControlador
{
    public class controlador
    {

        Sentencias sn = new Sentencias();

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public bool ingreso(string nom, string pass)
        {
            return sn.ingreso(nom,pass);
        }

        public ArrayList busquedaIndividual(string idu)
        {
            return sn.busquedaIndividual(idu);
        }

        public bool actuUsuario(string id, string nom, string pass)
        {
            return sn.actuUsuario(id, nom, pass);
        }

        public bool deleteUser(string id)
        {
            return sn.deleteUser(id);
        }

        //metodo para buscar ciudad
        public ArrayList busquedaCine()
        {
            return sn.busquedaCine();
        }

        //busqueda general tipos privilegios
        /*public DataTable llenarTblPriv()
        {
            OdbcDataAdapter dt = sn.llenarTblPriv();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }*/

        public DataTable llenarTblPrivUser(string id)
        {
            OdbcDataAdapter dt = sn.llenarTblPrivUser(id);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table; 
        }

        public bool ingPriv(string idU, string idP)
        {
            return sn.ingPriv(idU,idP);
        }
        public ArrayList privilegios()
        {
            return sn.privilegios();
        }
        public bool modifPriv(string idPriv, string idP)
        {
            return sn.modifPriv(idPriv, idP);
        }

        public bool elPriv( string idPriv)
        {
            return sn.elPriv(idPriv);
        }

        public bool iniciaSesion(string user, string pass)
        {

            return sn.iniciaSesion(user, pass);

        }
        public DataTable ConsultaPeliculas()
        {
            OdbcDataAdapter dt = sn.ConsultaPeliculas();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }


}
