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
    public partial class frmServicio : Form
    {
        string Operacion = "Insertar";

        public frmServicio()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //visibiliza o desabilitavisibilidad campos
            dataGridView1.Visible = false;
            txtFiltrar.Visible = false;
            btnNuevo.Visible = false;
            btnGuardar.Visible = true;
            pNuevo.Visible = true;
            //desabilita botones
            btnModificar.Enabled = false;
            btnBuscar.Enabled = false;
            btnImprimir.Enabled = false;
            btnEliminar.Enabled = false;            
            //indica la accion a realizar en el Boton            
            Operacion = "Insertar";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsServicio objServicio = new clsServicio();
            clsServicioDatos objServicioDatos = new clsServicioDatos();

            if (Operacion == "Insertar")
            {
                objServicio.Descripcion = txtServicio.Text.Trim();
                objServicio.IdDepartamento = int.Parse(cmbDepartamento.SelectedValue.ToString());
                objServicioDatos.InsertarServicios(objServicio);
                MessageBox.Show("Se Inserto Correctamente");

                dataGridView1.Visible = true;
                pNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnNuevo.Visible = true;
                txtFiltrar.Visible = false;
                //
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                btnBuscar.Enabled = true;               
            }
            else if (Operacion == "Editar")
            {
                objServicio.IdServicio = int.Parse(lblIdServicio.Text);
                objServicio.Descripcion = txtServicio.Text.Trim();
                objServicio.IdDepartamento = int.Parse(cmbDepartamento.SelectedValue.ToString());
                objServicioDatos.ActualizarServicio(objServicio);                
                MessageBox.Show("Se Actualizo la informacion Correctamente");

                dataGridView1.Visible = true;
                pNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnNuevo.Visible = true;
                btnNuevo.Enabled = true;
                txtFiltrar.Visible = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                btnBuscar.Enabled = true;
            }
            ListarDatagridViewServicios();
            ConfigurarDataGridView();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != -1)
            {
                dataGridView1.Visible = false;
                pNuevo.Visible = true;
                btnNuevo.Visible = false;
                btnGuardar.Visible = true;
                txtFiltrar.Visible = false;

                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;

                try
                {
                    clsServicio objServicio = new clsServicio();
                    objServicio.IdServicio = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    objServicio.Descripcion = dataGridView1.SelectedRows[0].Cells["Servicio"].Value.ToString();
                    objServicio.IdDepartamento = int.Parse(dataGridView1.SelectedRows[0].Cells["IDdep"].Value.ToString());
                                      
                    lblIdServicio.Text = objServicio.IdServicio.ToString();
                    cmbDepartamento.SelectedValue = objServicio.IdDepartamento;
                    txtServicio.Text = objServicio.Descripcion;
                    Operacion = "Editar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun registro");
            }
            ListarDatagridViewServicios();
            ConfigurarDataGridView();
        }

        private void ListarDatagridViewServicios()
        {
            clsServicioDatos objServicioDatos = new clsServicioDatos();
            dataGridView1.DataSource = objServicioDatos.LlenarDataGridViewServicio();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["IDdep"].Visible = false;           

            //Dimensionar un datagrid
            dataGridView1.Columns["Departamento"].Width = 350;
            dataGridView1.Columns["servicio"].Width = 270;
            //dataGridView1.Columns["Jefe"].Width = 250;//
            //Tipo de centrado al datagrid
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void ListarDepartamento()
        {
            clsDepartamentoDatos objDepartamentoDatos = new clsDepartamentoDatos(); ;
            cmbDepartamento.DataSource = objDepartamentoDatos.LlenarComboBoxDepartamento();
            cmbDepartamento.ValueMember = "ID";
            cmbDepartamento.DisplayMember = "descripcion";
        }

        private void frmServicio_Load(object sender, EventArgs e)
        {
            ListarDatagridViewServicios();
            ConfigurarDataGridView();
            ListarDepartamento();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsServicio objServicio = new clsServicio();            
            int ctass_fil_sel = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (ctass_fil_sel > 0)
            {
                if (MessageBox.Show("¿Retirar Producto(s)?",
                    "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    objServicio.IdServicio = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    clsServicioDatos objServicioDatos = new clsServicioDatos();                    
                    objServicioDatos.EliminarServicio(objServicio);                    
                    MessageBox.Show("Se Elimino Correctamente");
                }
            }
            else
            {
                MessageBox.Show("Seleccione Fila a Eliminar");
            }
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            ListarDatagridViewServicios();
            ConfigurarDataGridView();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltrar.Visible = true;
            txtFiltrar.Focus();
            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            BuscarTareas(txtFiltrar.Text);
        }

        private void BuscarTareas(string condicion)
        {
            clsServicioDatos objServicioDatos = new clsServicioDatos();            
            dataGridView1.DataSource = objServicioDatos.Filtrar(condicion);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (pNuevo.Visible.Equals(true))
            {
                pNuevo.Visible = false;
                dataGridView1.Visible = true;
                btnGuardar.Visible = false;
                btnNuevo.Visible = true;
                txtFiltrar.Visible = false;

                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
            }
            else
            {              
                this.Dispose();
            }
        }
    }
}
