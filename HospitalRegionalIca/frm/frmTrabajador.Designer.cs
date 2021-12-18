namespace HospitalRegionalIca
{
    partial class frmTrabajador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pTitulo = new System.Windows.Forms.Panel();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblTrabajado = new System.Windows.Forms.Label();
            this.pBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pGrid = new System.Windows.Forms.Panel();
            this.pNuevo = new System.Windows.Forms.Panel();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.cmbPersonal = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtRemuneracion = new System.Windows.Forms.TextBox();
            this.lblRemuneracion = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtPlaza = new System.Windows.Forms.TextBox();
            this.lblPlaza = new System.Windows.Forms.Label();
            this.txtSNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPNombre = new System.Windows.Forms.TextBox();
            this.lblPNombre = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblIdTrabajador = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pTitulo.SuspendLayout();
            this.pBotones.SuspendLayout();
            this.pGrid.SuspendLayout();
            this.pNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pTitulo.Controls.Add(this.txtFiltrar);
            this.pTitulo.Controls.Add(this.lblTrabajado);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(933, 52);
            this.pTitulo.TabIndex = 1;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(296, 16);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(345, 22);
            this.txtFiltrar.TabIndex = 10;
            this.txtFiltrar.Visible = false;
            // 
            // lblTrabajado
            // 
            this.lblTrabajado.AutoSize = true;
            this.lblTrabajado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajado.ForeColor = System.Drawing.Color.Black;
            this.lblTrabajado.Location = new System.Drawing.Point(105, 12);
            this.lblTrabajado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrabajado.Name = "lblTrabajado";
            this.lblTrabajado.Size = new System.Drawing.Size(112, 23);
            this.lblTrabajado.TabIndex = 8;
            this.lblTrabajado.Text = "Trabajador";
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.Color.Transparent;
            this.pBotones.Controls.Add(this.btnSalir);
            this.pBotones.Controls.Add(this.btnImprimir);
            this.pBotones.Controls.Add(this.btnBuscar);
            this.pBotones.Controls.Add(this.btnEliminar);
            this.pBotones.Controls.Add(this.btnModificar);
            this.pBotones.Controls.Add(this.btnNuevo);
            this.pBotones.Controls.Add(this.btnGuardar);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBotones.Location = new System.Drawing.Point(0, 52);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(94, 536);
            this.pBotones.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::HospitalRegionalIca.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(13, 386);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 65);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::HospitalRegionalIca.Properties.Resources.Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(13, 313);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(74, 65);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::HospitalRegionalIca.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(13, 240);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 65);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::HospitalRegionalIca.Properties.Resources.Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(12, 167);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 65);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::HospitalRegionalIca.Properties.Resources.Actualizar;
            this.btnModificar.Location = new System.Drawing.Point(13, 94);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 65);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::HospitalRegionalIca.Properties.Resources.Nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(13, 21);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(74, 65);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::HospitalRegionalIca.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(12, 21);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 65);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            // 
            // pGrid
            // 
            this.pGrid.BackColor = System.Drawing.Color.Transparent;
            this.pGrid.Controls.Add(this.pNuevo);
            this.pGrid.Controls.Add(this.dataGridView1);
            this.pGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrid.Location = new System.Drawing.Point(94, 52);
            this.pGrid.Name = "pGrid";
            this.pGrid.Size = new System.Drawing.Size(839, 536);
            this.pGrid.TabIndex = 3;
            // 
            // pNuevo
            // 
            this.pNuevo.BackgroundImage = global::HospitalRegionalIca.Properties.Resources.main_bg07;
            this.pNuevo.Controls.Add(this.chbEstado);
            this.pNuevo.Controls.Add(this.lblEstado);
            this.pNuevo.Controls.Add(this.dtpFIngreso);
            this.pNuevo.Controls.Add(this.lblPersonal);
            this.pNuevo.Controls.Add(this.cmbPersonal);
            this.pNuevo.Controls.Add(this.lblCategoria);
            this.pNuevo.Controls.Add(this.cmbCategoria);
            this.pNuevo.Controls.Add(this.lblCargo);
            this.pNuevo.Controls.Add(this.cmbCargo);
            this.pNuevo.Controls.Add(this.txtDNI);
            this.pNuevo.Controls.Add(this.lblDNI);
            this.pNuevo.Controls.Add(this.lblFechaNacimiento);
            this.pNuevo.Controls.Add(this.dtpFNacimiento);
            this.pNuevo.Controls.Add(this.txtRemuneracion);
            this.pNuevo.Controls.Add(this.lblRemuneracion);
            this.pNuevo.Controls.Add(this.txtNivel);
            this.pNuevo.Controls.Add(this.lblNivel);
            this.pNuevo.Controls.Add(this.txtPlaza);
            this.pNuevo.Controls.Add(this.lblPlaza);
            this.pNuevo.Controls.Add(this.txtSNombre);
            this.pNuevo.Controls.Add(this.label1);
            this.pNuevo.Controls.Add(this.txtPNombre);
            this.pNuevo.Controls.Add(this.lblPNombre);
            this.pNuevo.Controls.Add(this.txtMaterno);
            this.pNuevo.Controls.Add(this.lblMaterno);
            this.pNuevo.Controls.Add(this.txtPaterno);
            this.pNuevo.Controls.Add(this.lblPaterno);
            this.pNuevo.Controls.Add(this.lblDepartamento);
            this.pNuevo.Controls.Add(this.cmbDepartamento);
            this.pNuevo.Controls.Add(this.lblServicio);
            this.pNuevo.Controls.Add(this.lblIdTrabajador);
            this.pNuevo.Location = new System.Drawing.Point(30, 21);
            this.pNuevo.Name = "pNuevo";
            this.pNuevo.Size = new System.Drawing.Size(626, 342);
            this.pNuevo.TabIndex = 5;
            this.pNuevo.Visible = false;
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Location = new System.Drawing.Point(436, 147);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(15, 14);
            this.chbEstado.TabIndex = 38;
            this.chbEstado.UseVisualStyleBackColor = true;
            this.chbEstado.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(355, 147);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 17);
            this.lblEstado.TabIndex = 37;
            this.lblEstado.Text = "Estado";
            // 
            // dtpFIngreso
            // 
            this.dtpFIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFIngreso.Location = new System.Drawing.Point(165, 294);
            this.dtpFIngreso.Name = "dtpFIngreso";
            this.dtpFIngreso.Size = new System.Drawing.Size(106, 22);
            this.dtpFIngreso.TabIndex = 36;
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Location = new System.Drawing.Point(41, 236);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(58, 17);
            this.lblPersonal.TabIndex = 35;
            this.lblPersonal.Text = "Personal";
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.Location = new System.Drawing.Point(165, 232);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Size = new System.Drawing.Size(296, 25);
            this.cmbPersonal.TabIndex = 34;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(41, 205);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 33;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(165, 201);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(296, 25);
            this.cmbCategoria.TabIndex = 32;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(41, 174);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(45, 17);
            this.lblCargo.TabIndex = 31;
            this.lblCargo.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(165, 170);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(296, 25);
            this.cmbCargo.TabIndex = 30;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(165, 86);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(159, 22);
            this.txtDNI.TabIndex = 29;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(41, 92);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 17);
            this.lblDNI.TabIndex = 28;
            this.lblDNI.Text = "DNI";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(41, 145);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(118, 17);
            this.lblFechaNacimiento.TabIndex = 27;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // dtpFNacimiento
            // 
            this.dtpFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFNacimiento.Location = new System.Drawing.Point(165, 142);
            this.dtpFNacimiento.Name = "dtpFNacimiento";
            this.dtpFNacimiento.Size = new System.Drawing.Size(106, 22);
            this.dtpFNacimiento.TabIndex = 26;
            // 
            // txtRemuneracion
            // 
            this.txtRemuneracion.Location = new System.Drawing.Point(165, 114);
            this.txtRemuneracion.Name = "txtRemuneracion";
            this.txtRemuneracion.Size = new System.Drawing.Size(159, 22);
            this.txtRemuneracion.TabIndex = 25;
            // 
            // lblRemuneracion
            // 
            this.lblRemuneracion.AutoSize = true;
            this.lblRemuneracion.Location = new System.Drawing.Point(41, 117);
            this.lblRemuneracion.Name = "lblRemuneracion";
            this.lblRemuneracion.Size = new System.Drawing.Size(94, 17);
            this.lblRemuneracion.TabIndex = 24;
            this.lblRemuneracion.Text = "Remuneracion";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(436, 114);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(159, 22);
            this.txtNivel.TabIndex = 23;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(355, 117);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(39, 17);
            this.lblNivel.TabIndex = 22;
            this.lblNivel.Text = "Nivel";
            // 
            // txtPlaza
            // 
            this.txtPlaza.Location = new System.Drawing.Point(436, 86);
            this.txtPlaza.Name = "txtPlaza";
            this.txtPlaza.Size = new System.Drawing.Size(159, 22);
            this.txtPlaza.TabIndex = 21;
            // 
            // lblPlaza
            // 
            this.lblPlaza.AutoSize = true;
            this.lblPlaza.Location = new System.Drawing.Point(355, 89);
            this.lblPlaza.Name = "lblPlaza";
            this.lblPlaza.Size = new System.Drawing.Size(39, 17);
            this.lblPlaza.TabIndex = 20;
            this.lblPlaza.Text = "Plaza";
            // 
            // txtSNombre
            // 
            this.txtSNombre.Location = new System.Drawing.Point(436, 58);
            this.txtSNombre.Name = "txtSNombre";
            this.txtSNombre.Size = new System.Drawing.Size(159, 22);
            this.txtSNombre.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "SNombre";
            // 
            // txtPNombre
            // 
            this.txtPNombre.Location = new System.Drawing.Point(165, 58);
            this.txtPNombre.Name = "txtPNombre";
            this.txtPNombre.Size = new System.Drawing.Size(159, 22);
            this.txtPNombre.TabIndex = 17;
            // 
            // lblPNombre
            // 
            this.lblPNombre.AutoSize = true;
            this.lblPNombre.Location = new System.Drawing.Point(41, 61);
            this.lblPNombre.Name = "lblPNombre";
            this.lblPNombre.Size = new System.Drawing.Size(63, 17);
            this.lblPNombre.TabIndex = 16;
            this.lblPNombre.Text = "PNombre";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(436, 30);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(159, 22);
            this.txtMaterno.TabIndex = 15;
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(355, 33);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(59, 17);
            this.lblMaterno.TabIndex = 14;
            this.lblMaterno.Text = "Materno";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(165, 30);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(159, 22);
            this.txtPaterno.TabIndex = 13;
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Location = new System.Drawing.Point(41, 33);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(55, 17);
            this.lblPaterno.TabIndex = 12;
            this.lblPaterno.Text = "Paterno";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(41, 267);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(97, 17);
            this.lblDepartamento.TabIndex = 11;
            this.lblDepartamento.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(165, 263);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(296, 25);
            this.cmbDepartamento.TabIndex = 9;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(41, 299);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(91, 17);
            this.lblServicio.TabIndex = 5;
            this.lblServicio.Text = "Fecha Ingreso";
            // 
            // lblIdTrabajador
            // 
            this.lblIdTrabajador.AutoSize = true;
            this.lblIdTrabajador.Location = new System.Drawing.Point(406, 10);
            this.lblIdTrabajador.Name = "lblIdTrabajador";
            this.lblIdTrabajador.Size = new System.Drawing.Size(20, 17);
            this.lblIdTrabajador.TabIndex = 4;
            this.lblIdTrabajador.Text = "ID";
            this.lblIdTrabajador.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(725, 430);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalRegionalIca.Properties.Resources.main_bg08;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.pGrid);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.pTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTrabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajador";
            this.Load += new System.EventHandler(this.frmTrabajador_Load);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pBotones.ResumeLayout(false);
            this.pGrid.ResumeLayout(false);
            this.pNuevo.ResumeLayout(false);
            this.pNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lblTrabajado;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pGrid;
        private System.Windows.Forms.Panel pNuevo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblIdTrabajador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dtpFIngreso;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFNacimiento;
        private System.Windows.Forms.TextBox txtRemuneracion;
        private System.Windows.Forms.Label lblRemuneracion;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TextBox txtPlaza;
        private System.Windows.Forms.Label lblPlaza;
        private System.Windows.Forms.TextBox txtSNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPNombre;
        private System.Windows.Forms.Label lblPNombre;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label lblPaterno;
    }
}