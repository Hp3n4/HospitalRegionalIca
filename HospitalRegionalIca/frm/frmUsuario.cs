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
    public partial class frmUsuario : Form
    {
        string Operacion = "Insertar";

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            ListarDatagridViewDepartamento();
            ConfigurarDataGridView();
            ListarDepartamento();
            ListarRol();
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
            chbEstado.Checked = true;
            //indica la accion a realizar en el Boton            
            Operacion = "Insertar";
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
                    clsUsuario objUsuario = new clsUsuario();
                    objUsuario.IdUsuario = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    objUsuario.Nombre = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();
                    objUsuario.NombreUsuario = dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString();
                    objUsuario.Contraseña = dataGridView1.SelectedRows[0].Cells["Contraseña"].Value.ToString();
                    objUsuario.Estado = dataGridView1.SelectedRows[0].Cells["estado"].Value.ToString();
                    objUsuario.IdDepartamento = int.Parse(dataGridView1.SelectedRows[0].Cells["id_departamento"].Value.ToString());
                    objUsuario.IdRol = int.Parse(dataGridView1.SelectedRows[0].Cells["id_rol"].Value.ToString());

                    lblIdUsuario.Text = objUsuario.IdUsuario.ToString();
                    txtNombre.Text = objUsuario.Nombre.ToString();
                    txtUsuario.Text = objUsuario.NombreUsuario.ToString();
                    txtContraseña.Text = objUsuario.Contraseña.ToString();
                    chbEstado.Checked = bool.Parse(objUsuario.Estado);
                    cmbDepartamento.SelectedValue = objUsuario.IdDepartamento.ToString();
                    cmbRol.SelectedValue = objUsuario.IdRol.ToString();
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

        private void ListarDepartamento()
        {
            clsDepartamentoDatos objDepartamentoDatos = new clsDepartamentoDatos();
            cmbDepartamento.DataSource = objDepartamentoDatos.LlenarComboBoxDepartamento();
            cmbDepartamento.ValueMember = "ID";
            cmbDepartamento.DisplayMember = "descripcion";
        }
        private void ListarRol()
        {
            clsUsuarioDatos objUsuarioDatos = new clsUsuarioDatos();
            cmbRol.DataSource = objUsuarioDatos.LlenarComboBoxRol();
            cmbRol.ValueMember = "ID";
            cmbRol.DisplayMember = "descripcion";
        }

        private void ListarDatagridViewDepartamento()
        {
            clsUsuarioDatos objUsuarioDatos = new clsUsuarioDatos();
            dataGridView1.DataSource = objUsuarioDatos.LlenarDataGridViewDepartamento();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["id_rol"].Visible = false;
            dataGridView1.Columns["id_departamento"].Visible = false;
            dataGridView1.Columns["nombre"].Visible = false;
            
            //Dimensionar un datagrid
            dataGridView1.Columns["Departamento"].Width = 220;
            dataGridView1.Columns["fecha"].Width = 85;
            //dataGridView1.Columns["Jefe"].Width = 250;//
            //Tipo de centrado al datagrid
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsUsuario objUsuario = new clsUsuario();            

            if (Operacion == "Insertar")
            {
                objUsuario.Nombre = txtNombre.Text.Trim();
                objUsuario.NombreUsuario = txtUsuario.Text.Trim();
                objUsuario.Contraseña = txtContraseña.Text.Trim();
                objUsuario.Estado = chbEstado.Text.Trim();
                objUsuario.IdDepartamento = int.Parse(cmbDepartamento.SelectedValue.ToString());
                objUsuario.IdRol =int.Parse(cmbRol.SelectedValue.ToString());
                clsUsuarioDatos objUsuarioDatos = new clsUsuarioDatos();
                objUsuarioDatos.InsertarUsuario(objUsuario);                
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
                chbEstado.Checked = false;
            }
            else if (Operacion == "Editar")
            {
                objUsuario.IdUsuario = int.Parse(lblIdUsuario.Text);
                objUsuario.Nombre = txtNombre.Text.Trim();
                objUsuario.NombreUsuario = txtUsuario.Text.Trim();
                objUsuario.Contraseña = txtContraseña.Text.Trim();
                objUsuario.Estado = chbEstado.Checked.ToString();
                objUsuario.IdDepartamento = int.Parse(cmbDepartamento.SelectedValue.ToString());
                objUsuario.IdRol = int.Parse(cmbRol.SelectedValue.ToString());
                clsUsuarioDatos objUsuarioDatos = new clsUsuarioDatos();
                objUsuarioDatos.ActualizarUsuario(objUsuario);
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
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
            }
            else
            {
                chbEstado.Checked = false;
                this.Dispose();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsUsuario objUsuario = new clsUsuario();            
            int ctass_fil_sel = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (ctass_fil_sel > 0)
            {
                if (MessageBox.Show("¿Retirar Producto(s)?",
                    "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    objUsuario.IdUsuario = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    clsUsuarioDatos objUsuarioDatos = new clsUsuarioDatos();
                    objUsuarioDatos.EliminarUsuario(objUsuario);
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
            clsUsuarioDatos objUsuarioDatos = new clsUsuarioDatos();            
            dataGridView1.DataSource = objUsuarioDatos.Filtrar(condicion);
        }
    }
}
