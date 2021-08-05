using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //Its for MySQL 

namespace CapaVista
{
    public partial class PruebaBD : Form
    {
        public PruebaBD()
        {
            InitializeComponent();
        }

        private void PruebaBD_Load(object sender, EventArgs e)
        {

        }

        private void boton_enviar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //base para elaborar la conexion
            /*
               try  
   {  
            //This is my connection string i have assigned the database file address path  
            string MyConnection2 = "datasource=localhost;port=3307;username=root;password=root";  
            //This is my insert query in which i am taking input from the user through windows forms  
            string Query = "insert into student.studentinfo(idStudentInfo,Name,Father_Name,Age,Semester) values('" +this.IdTextBox.Text+ "','" +this.NameTextBox.Text+ "','" +this.FnameTextBox.Text+ "','" +this.AgeTextBox.Text+ "','" +this.SemesterTextBox.Text+ "');";  
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);  
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);  
            MySqlDataReader MyReader2;  
            MyConn2.Open();  
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            MessageBox.Show("Save Data");  
            while (MyReader2.Read())  
            {                     
            }  
            MyConn2.Close();  
        }  
        catch (Exception ex)  
        {   
            MessageBox.Show(ex.Message);  
      }   */

            //JAva string prueba= t1.getText()

            //para obtener texto debo usar la propiedad text obtiene el texto actual del elemento
            String usuario = t1.Text;
            String pas = t2.Text;

            //////

            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=123456789;database=cinevision";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into usuarios(Usuario,Password) values('" + this.t1.Text + "','" + this.t2.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Datos Guardados");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ///





        }
    }
}
