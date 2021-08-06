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
    public partial class frmElecciónAdmin : Form
    {
        public frmElecciónAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmAU = new frmAdminUsuarios();
            frmAU.Show();
            this.Hide();
          
        }

        private void btnGenerarReportes_Click(object sender, EventArgs e)
        {
            var frmGR = new frmGenerarReportes();
            frmGR.Show();
            this.Hide();
        }

        private void btnEdicionCartelera_Click(object sender, EventArgs e)
        {
            var frmEC = new frmEdiciónCartelera();
            frmEC.Show();
            this.Hide();
        }
    }
}
