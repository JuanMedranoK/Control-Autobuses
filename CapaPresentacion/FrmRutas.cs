using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmRutas : Form
    {
        public FrmRutas()
        {
            InitializeComponent();
        }

        N_Rutas objNegocio = new N_Rutas();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                E_Rutas.ID_Chofer1 = int.Parse(txtIdChofer.Text);
                E_Rutas.ID_Autobus1 = int.Parse(txtIdAuto.Text);
                E_Rutas.Rutas1 = comboBoxRutas.Text.ToUpper();

                objNegocio.Guardando_N();

                MessageBox.Show("Guardado");
                dataGridViewRutas.DataSource = objNegocio.Mostrando_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnEdiar_Click(object sender, EventArgs e)
        {
            try
            {
                E_Rutas.ID1 = int.Parse(txtID.Text);
                E_Rutas.ID_Chofer1 = int.Parse(txtIdChofer.Text);
                E_Rutas.ID_Autobus1 = int.Parse(txtIdAuto.Text);
                E_Rutas.Rutas1 = comboBoxRutas.Text.ToUpper();

                objNegocio.Editando_N();

                MessageBox.Show(" Editado");
                dataGridViewRutas.DataSource = objNegocio.Mostrando_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                E_Rutas.ID1 = int.Parse(txtID.Text);
                E_Rutas.ID_Chofer1 = int.Parse(txtIdChofer.Text);
                E_Rutas.ID_Autobus1 = int.Parse(txtIdAuto.Text);

                objNegocio.Buscando_N();

                dataGridViewRutas.DataSource = objNegocio.Mostrando_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                E_Rutas.ID1 = int.Parse(txtID.Text);
                E_Rutas.ID_Chofer1 = int.Parse(txtIdChofer.Text);

                objNegocio.Borrando_N();

                MessageBox.Show(" Eliminado");
                dataGridViewRutas.DataSource = objNegocio.Mostrando_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
        public void Limpiar_C()
        {
            foreach (Control tool in Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar_C();
        }

        private void FrmRutas_Load(object sender, EventArgs e)
        {
            dataGridViewRutas.DataSource = objNegocio.Mostrando_N();
        }

        private void dataGridViewRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
