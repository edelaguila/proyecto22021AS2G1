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
    public partial class frmIngresoHorario : Form
    {
        controlador cn = new controlador();
        public frmIngresoHorario()
        {
            InitializeComponent();
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            var frmH = new frmHorarios();
            frmH.Show();
            this.Close();
        }

        private void btnIngH_Click(object sender, EventArgs e)
        {
            string fechahora = dtp.Text;
            //MessageBox.Show("selección: " + fechahora);
            bool resultado = cn.ingresoHorario(fechahora);
            if (resultado)
            {
                MessageBox.Show("Ingreso de horario correcto");
            }
            else
            {
                MessageBox.Show("Ingreso de horario fallido");
            }
        }
    }
}
