using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

      

        private Form OpenContenedor;

        private void OpenPanelConten(Form OpenFrm)
        {
            if (OpenContenedor != null)
            {
                OpenContenedor.Close();
            }
            OpenContenedor = OpenFrm;
            OpenFrm.TopLevel = false;
            OpenFrm.FormBorderStyle = FormBorderStyle.None;
            OpenFrm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(OpenFrm);
            panelContenedor.Tag = OpenFrm;
            OpenFrm.BringToFront();
            OpenFrm.Show();

        }

        private void buttonCH_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmChoferes());
        }

        private void buttonAUT_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmAutobuses());
        }

        private void buttonRT_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmRutas());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelf.Text = DateTime.Now.ToShortDateString();
        }

     

       
    }
}
