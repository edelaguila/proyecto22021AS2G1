using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControlador;
using CapaModelo;
using System.Data;
using System.Data.Odbc;


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


    }

}
