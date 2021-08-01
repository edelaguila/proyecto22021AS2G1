using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data;

namespace CapaControlador
{//es publico por que se accedera desde otras capas
    public class controlador
    {

        consultas consul = new consultas();

        //el metodo crea el datatable donde se pasaran los datos que se obtuvieron de la consulta

        //nuestro metodo

        public DataTable llenarTbl()
        {
            DataTable consulta = consul.llenarTbl();

            return consulta;


        }

        /*
         // LLenar una tabla CAPA CONTROLADOR


     public DataTable llenarTbl(string tabla)  
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla); en nuestro caso es consul = sn
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
          
         */


    }
}
