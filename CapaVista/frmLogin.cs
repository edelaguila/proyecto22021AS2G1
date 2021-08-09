using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmLogin : Form
    {
        controlador cn = new controlador();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool encontrado = false;
            string user = txtUser.Text;
            string pass = txtPass.Text;
            encontrado = cn.iniciaSesion(user, pass);

            if (encontrado)
            {
                var frmAdmin = new frmElecciónAdmin();
                frmAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas, intente de nuevo");
            }
        }
    }
}
