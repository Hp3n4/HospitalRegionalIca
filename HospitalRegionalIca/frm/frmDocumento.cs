using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRegionalIca
{
    public partial class frmDocumento : Form
    {
        public frmDocumento()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            btnModificar.Enabled = false;
            btneliminar.Enabled = false;
            btnBuscar.Enabled = false;
            btnImprimir.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblBuscar.Visible = true;
            txtBuscar.Visible=true;
        }
    }
}
