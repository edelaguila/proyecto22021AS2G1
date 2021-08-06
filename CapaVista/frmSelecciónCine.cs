using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmSelecciónCine : Form
    {
        public frmSelecciónCine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) /*boton ver cartelera*/
        {
            var frmMU = new frmCartelera();
            frmMU.Show();
            this.Close();
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            var frmME = new frmMenuEntrada();
            frmME.Show();
            this.Close();
        }
    }
}
