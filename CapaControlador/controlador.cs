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
        public ArrayList busquedaCiudad()
        {
            return sn.busquedaCiudad();
        }

    }

}
