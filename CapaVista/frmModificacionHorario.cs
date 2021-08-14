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
    public partial class frmModificacionHorario : Form
    {
        controlador cn = new controlador();
        public frmModificacionHorario()
        {
            InitializeComponent();
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            var frmH = new frmHorarios();
            frmH.Show();
            this.Close();
        }

        private void frmModificacionHorario_Load(object sender, EventArgs e)
        {
            cmbHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeli.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSala.DropDownStyle = ComboBoxStyle.DropDownList;

            var listaPelis = cn.busquedaPeli();

            for (int i = 0; i < listaPelis.Count; i++)
            {
                cmbPeli.Items.Add(listaPelis[i].ToString());
            }

            var listaHorarios = cn.busquedaHorario();

            for (int i = 0; i < listaHorarios.Count; i++)
            {
                cmbHorario.Items.Add(listaHorarios[i].ToString());
            }

            var listaSalas = cn.busquedaSala();

            for (int i = 0; i < listaSalas.Count; i++)
            {
                cmbSala.Items.Add(listaSalas[i].ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            DataTable data = cn.consultaIndHorariCi(id);
            dgvDatosInd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatosInd.DataSource = data;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string mnsj = "¿Desea cambiar los datos actuales por los nuevos datos?";
            string titulo = "Confirmación";
            int horario = cmbHorario.SelectedIndex + 1;
            int sala = cmbSala.SelectedIndex + 1;
            int peli = cmbPeli.SelectedIndex + 1;

            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                bool result = cn.modifHorarioPeli(peli + "", sala + "", horario + "",id);
                if (result)
                {
                    MessageBox.Show("Modificación de datos correcta");
                }
                else
                {
                    MessageBox.Show("Modificación de datos fallida");
                }
            }
        }
    }
}
