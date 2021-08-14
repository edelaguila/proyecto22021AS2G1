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


        public bool ingresoPeliculas(string nom, string clas, string gen, string sub, string idio, string preci, string sinop, object imagen)
        {
            return sn.ingresoPeliculas(nom,  clas, gen, sub, idio,  preci, sinop, imagen);

        }


        public ArrayList busquedaIndividualPelis(string idu)
        {
            return sn.busquedaIndividualPelis(idu);
        }

        public DataTable llenarTblPeli()
        {
            OdbcDataAdapter dt = sn.llenarTblPeli();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblPeliInd(string id)
        {
            OdbcDataAdapter dt = sn.llenarTblPeliInd(id);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public bool actuPelis(string id, string nom, string clasif, string gen, string sub, string idim, string preci, string sinop)
        {
            return sn.actuPelis(id, nom, clasif, gen, sub, idim, preci, sinop);
        }

        public bool elimPelis(string id)
        {
            return sn.elimPelis(id);
        }
        public ArrayList busquedaPeliD()
        {
            return sn.busquedaPeliD();
        }

        public DataTable llenarTblPeliD(string peliid)
        {
            OdbcDataAdapter dt = sn.llenarTblPeliD(peliid);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public bool elimPeliD(string id)
        {
            return sn.elimPeliD(id);
        }

        public bool altaPeliD(string id)
        {
            return sn.altaPeliD(id);
        }

        public bool ingresoHorario( string fechahora)
        {
            return sn.ingresoHorario(fechahora);
        }

        public ArrayList busquedaPeli()
        {
            return sn.busquedaPeli();
        }

        public ArrayList busquedaSala()
        {
            return sn.busquedaSala();
        }

        public ArrayList busquedaHorario()
        {
            return sn.busquedaHorario();
        }

        public bool ingHorarioPeli(string peli, string sala, string horario)
        {
            return sn.ingHorarioPeli(peli, sala, horario);
        }
    }

}
