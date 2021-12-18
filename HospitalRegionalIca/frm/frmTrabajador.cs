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
    public partial class frmTrabajador : Form
    {
        string Operacion = "Insertar";
        public frmTrabajador()
        {
            InitializeComponent();
        }

        private void frmTrabajador_Load(object sender, EventArgs e)
        {
            ListarDatagridViewTrabajador();
            ConfigurarDataGridView();
            ListarDepartamento();
            ListarCargo();
            ListarCategoria();
            ListarPersonal();
        }

        private void ListarDatagridViewTrabajador()
        {
            clsTrabajadorDatos objTrabajadorDatos = new clsTrabajadorDatos();
            dataGridView1.DataSource = objTrabajadorDatos.LlenarDataGridViewTrabajador();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns["ID"].Visible = false;           
            dataGridView1.Columns["id_cargo"].Visible = false;
            dataGridView1.Columns["id_categoria"].Visible = false;
            dataGridView1.Columns["id_personal"].Visible = false;
            dataGridView1.Columns["id_departamento"].Visible = false;
            dataGridView1.Columns["FNacimiento"].Visible = false;
            dataGridView1.Columns["FIngreso"].Visible = false;
            dataGridView1.Columns["Remuneracion"].Visible = false;
            dataGridView1.Columns["Estado"].Visible = false;
            dataGridView1.Columns["Personal"].Visible = false;
            dataGridView1.Columns["Cargo"].Visible = false;
            dataGridView1.Columns["Categoria"].Visible = false;
            dataGridView1.Columns["Departamento"].Visible = false;
            dataGridView1.Columns["APaterno"].Visible = false;
            dataGridView1.Columns["AMaterno"].Visible = false;
            dataGridView1.Columns["PNombre"].Visible = false;
            dataGridView1.Columns["SNombre"].Visible = false;

            //Dimensionar un datagrid
            dataGridView1.Columns["Departamento"].Width = 350;
            dataGridView1.Columns["DNI"].Width =70;
            dataGridView1.Columns["Trabajador"].Width = 290;
            dataGridView1.Columns["Plaza"].Width = 70;
            dataGridView1.Columns["Remuneracion"].Width = 70;
            
            dataGridView1.Columns["Estado"].Width = 70;
            
            
            //Tipo de centrado al datagrid
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Remuneracion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ListarDepartamento()
        {
            clsDepartamentoDatos objDepartamentoDatos = new clsDepartamentoDatos(); ;
            cmbDepartamento.DataSource = objDepartamentoDatos.LlenarComboBoxDepartamento();
            cmbDepartamento.ValueMember = "ID";
            cmbDepartamento.DisplayMember = "descripcion";
        }

        private void ListarCargo()
        {
            clsCargoDatos objCargoDatos = new clsCargoDatos();
            cmbCargo.DataSource = objCargoDatos.LlenarComboBoxCargo();
            cmbCargo.ValueMember = "ID";
            cmbCargo.DisplayMember = "descripcion";
        }

        private void ListarCategoria()
        {
            clsCategoriaDatos objCategoriaDatos = new clsCategoriaDatos();
            cmbCategoria.DataSource = objCategoriaDatos.LlenarComboBoxCategoria();
            cmbCategoria.ValueMember = "ID";
            cmbCategoria.DisplayMember = "descripcion";
        }

        private void ListarPersonal()
        {
            clsPersonalDatos objPersonalDatos = new clsPersonalDatos();
            cmbPersonal.DataSource = objPersonalDatos.LlenarComboBoxPersonal();
            cmbPersonal.ValueMember = "ID";
            cmbPersonal.DisplayMember = "descripcion";
        }

        private void Limpiar()
        {
            lblIdTrabajador.Text = "";
            txtDNI.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtPNombre.Text = "";
            txtSNombre.Text = "";
            txtPlaza.Text = "";
            txtRemuneracion.Text = "";
            txtNivel.Text = "";
            dtpFNacimiento.Text = "";
            chbEstado.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsTrabajador objTrabajdor = new clsTrabajador();
            int ctass_fil_sel = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (ctass_fil_sel > 0)
            {
                if (MessageBox.Show("¿Retirar Producto(s)?",
                    "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    objTrabajdor.IdTrabajador = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    clsTrabajadorDatos objTrabajadorDatos = new clsTrabajadorDatos();
                    objTrabajadorDatos.EliminarTrabajador(objTrabajdor);                    
                    MessageBox.Show("Se Elimino Correctamente");
                }
            }
            else
            {
                MessageBox.Show("Seleccione Fila a Eliminar");
            }
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            ListarDatagridViewTrabajador();
            ConfigurarDataGridView();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != -1)
            {
                Limpiar();
                dataGridView1.Visible = false;
                pNuevo.Visible = true;
                btnNuevo.Visible = false;
                btnGuardar.Visible = true;
                txtFiltrar.Visible = false;

                chbEstado.Visible = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;

                try
                {
                    clsTrabajador objTrabajador = new clsTrabajador();
                    objTrabajador.IdTrabajador = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    objTrabajador.DNI = dataGridView1.SelectedRows[0].Cells["DNI"].Value.ToString();
                    objTrabajador.ApellidoPaterno = dataGridView1.SelectedRows[0].Cells["APaterno"].Value.ToString();
                    objTrabajador.ApellidoMaterno = dataGridView1.SelectedRows[0].Cells["AMaterno"].Value.ToString();
                    objTrabajador.PrimerNombre = dataGridView1.SelectedRows[0].Cells["PNombre"].Value.ToString();
                    objTrabajador.SegundoNombre = dataGridView1.SelectedRows[0].Cells["SNombre"].Value.ToString();
                    objTrabajador.Plaza = dataGridView1.SelectedRows[0].Cells["Plaza"].Value.ToString();
                    objTrabajador.Remuneracion = decimal.Parse(dataGridView1.SelectedRows[0].Cells["Remuneracion"].Value.ToString());
                    objTrabajador.Nivel = dataGridView1.SelectedRows[0].Cells["Nivel"].Value.ToString();
                    //MessageBox.Show(dataGridView1.SelectedRows[0].Cells["FNacimiento"].Value.ToString());
                    objTrabajador.FechaNacimiento = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["FNacimiento"].Value.ToString());
                    objTrabajador.IdCargo = int.Parse(dataGridView1.SelectedRows[0].Cells["id_cargo"].Value.ToString());
                    objTrabajador.IdCategoria = int.Parse(dataGridView1.SelectedRows[0].Cells["id_categoria"].Value.ToString());
                    objTrabajador.IdPersonal = int.Parse(dataGridView1.SelectedRows[0].Cells["id_personal"].Value.ToString());
                    objTrabajador.IdDepartamento = int.Parse(dataGridView1.SelectedRows[0].Cells["id_departamento"].Value.ToString());
                    objTrabajador.FechaIngreso = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["FIngreso"].Value.ToString());
                    objTrabajador.Estado = dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString();
                                     
                    lblIdTrabajador.Text = objTrabajador.IdTrabajador.ToString();
                    txtDNI.Text = objTrabajador.DNI.ToString();
                    txtPaterno.Text = objTrabajador.ApellidoPaterno.ToString();
                    txtMaterno.Text = objTrabajador.ApellidoMaterno.ToString();
                    txtPNombre.Text = objTrabajador.PrimerNombre.ToString();
                    txtSNombre.Text = objTrabajador.SegundoNombre.ToString();
                    txtPlaza.Text = objTrabajador.Plaza.ToString();
                    txtRemuneracion.Text = objTrabajador.Remuneracion.ToString();
                    txtNivel.Text = objTrabajador.Nivel.ToString();
                    dtpFNacimiento.Text = objTrabajador.FechaNacimiento.ToString();
                    chbEstado.Checked = Boolean.Parse(objTrabajador.Estado.ToString());
                    cmbCargo.SelectedValue =objTrabajador.IdCargo.ToString();
                    cmbCategoria.SelectedValue =objTrabajador.IdCategoria.ToString();
                    cmbPersonal.SelectedValue = objTrabajador.IdPersonal.ToString();
                    cmbDepartamento.SelectedValue = objTrabajador.IdDepartamento.ToString();
                    dtpFIngreso.Text = objTrabajador.FechaIngreso.ToString();                    
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
            ListarDatagridViewTrabajador();
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
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                Limpiar();
            }
            else
            {
                this.Dispose();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarTareas(txtFiltrar.Text);
        }

        private void BuscarTareas(string condicion)
        {
            clsTrabajadorDatos objTrabajadorDatos = new clsTrabajadorDatos();
            dataGridView1.DataSource = objTrabajadorDatos.Filtrar(condicion);
        }
    }
}
