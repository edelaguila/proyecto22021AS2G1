using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //clase MYSQL

namespace CapaVista
{
    public partial class frmMantenimientoConsultaGeneralUsuarios : Form
    {
        public frmMantenimientoConsultaGeneralUsuarios()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //DataTable tabla = new DataTable();
            //dvgConsulta.DataSource = tabla;
            //codigo funcional
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
                dvgConsulta.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

