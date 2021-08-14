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
    public partial class frmEliminacionHorario : Form
    {
        controlador cn = new controlador();
        public frmEliminacionHorario()
        {
            InitializeComponent();
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            var frmH = new frmHorarios();
            frmH.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            DataTable data = cn.consultaIndHorariCi(id);
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.DataSource = data;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string mnsj = "¿Desea eliminar este horario?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                bool result = cn.elimHorarioPeli(id);
                if (result)
                {
                    MessageBox.Show("Eliminación de horario correcta");
                }
                else
                {
                    MessageBox.Show("Eliminación de horario fallida");
                }
            }

        }
    }
}
