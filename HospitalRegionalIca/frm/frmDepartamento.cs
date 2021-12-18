using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRegionalIca
{
    
    public partial class frmDepartamento : Form
    {
        string Operacion = "Insertar";

        public frmDepartamento()
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
            btneliminar.Enabled = false;
            //indica la accion a realizar en el Boton            
            Operacion = "Insertar";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsDepartamento objDepartamento = new clsDepartamento();
           
            if(Operacion == "Insertar")
            {                
                objDepartamento.Descripcion = txtDepartamento.Text.Trim();
                objDepartamento.Jefe = txtJefe.Text.Trim();
                clsDepartamentoDatos objDepartamentoDatos = new clsDepartamentoDatos();
                objDepartamentoDatos.InsertarDepartamento(objDepartamento);
                MessageBox.Show("Se Inserto Correctamente");
                dataGridView1.Visible = true;
                pNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnNuevo.Visible = true;
                txtFiltrar.Visible = false;
                //
                btnModificar.Enabled = true;
                btneliminar.Enabled = true;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                btnBuscar.Enabled = true;
            }
            else if(Operacion == "Editar")
            {
                objDepartamento.IdDepartamento = int.Parse(lblIdDepartamento.Text);
                objDepartamento.Descripcion = txtDepartamento.Text.Trim();
                objDepartamento.Jefe = txtJefe.Text.Trim();
                clsDepartamentoDatos objDepartamentoDatos = new clsDepartamentoDatos();
                objDepartamentoDatos.ActualizarDepartamento(objDepartamento);
                MessageBox.Show("Se Actualizo la informacion Correctamente");

                dataGridView1.Visible = true;
                pNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnNuevo.Visible = true;
                txtFiltrar.Visible = false;
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btneliminar.Enabled = true;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                btnBuscar.Enabled = true;
            }
            ListarDatagridViewDepartamento();
            ConfigurarDataGridView();
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
                btneliminar.Enabled = true;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
            }
            else
            {
                this.Dispose();
            }
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
                btneliminar.Enabled = false;
                btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;

                try
                {
                    clsDepartamento objDepartamento = new clsDepartamento();
                    objDepartamento.IdDepartamento = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    objDepartamento.Descripcion = dataGridView1.SelectedRows[0].Cells["Departamento"].Value.ToString();
                    objDepartamento.Jefe = dataGridView1.SelectedRows[0].Cells["Jefe"].Value.ToString();

                    lblIdDepartamento.Text = objDepartamento.IdDepartamento.ToString();
                    txtDepartamento.Text = objDepartamento.Descripcion.ToString();
                    txtJefe.Text = objDepartamento.Jefe.ToString();
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
            ListarDatagridViewDepartamento();
            ConfigurarDataGridView();
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            clsDepartamento objDepartamento = new clsDepartamento();
            int ctass_fil_sel = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (ctass_fil_sel > 0)
            {
                if (MessageBox.Show("¿Retirar Producto(s)?",
                    "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    objDepartamento.IdDepartamento = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    clsDepartamentoDatos objDepartamentoDatos = new clsDepartamentoDatos();
                    objDepartamentoDatos.EliminarDepartamento(objDepartamento);
                    MessageBox.Show("Se Elimino Correctamente"); 
                }
            }
            else
            {
                MessageBox.Show("Seleccione Fila a Eliminar");
            }
            btnBuscar.Enabled = true;
            ListarDatagridViewDepartamento();
            ConfigurarDataGridView();
        }
       
        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            ListarDatagridViewDepartamento();
            ConfigurarDataGridView();
        }

        private void ListarDatagridViewDepartamento()
        {
            clsDepartamentoDatos objDepartamentoDatos = new clsDepartamentoDatos();
            dataGridView1.DataSource = objDepartamentoDatos.LlenarDataGridViewDepartamento();                        
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns["ID"].Visible = false;
            //Dimensionar un datagrid
            dataGridView1.Columns["Departamento"].Width = 350;
            dataGridView1.Columns["Jefe"].Width = 250;            
            //Tipo de centrado al datagrid
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltrar.Visible = true;
            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            BuscarTareas(txtFiltrar.Text);
        }

        private void BuscarTareas(string condicion)
        {
            clsDepartamentoDatos objDepartamentoDatos = new clsDepartamentoDatos();
            dataGridView1.DataSource = objDepartamentoDatos.Filtrar(condicion); 
        }
    }
}
