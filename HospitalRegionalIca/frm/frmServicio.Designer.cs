namespace HospitalRegionalIca
{
    partial class frmServicio
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
            this.lblServici = new System.Windows.Forms.Label();
            this.pBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pGrid = new System.Windows.Forms.Panel();
            this.pNuevo = new System.Windows.Forms.Panel();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblIdServicio = new System.Windows.Forms.Label();
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
            this.pTitulo.Controls.Add(this.lblServici);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(933, 40);
            this.pTitulo.TabIndex = 0;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(254, 12);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(296, 22);
            this.txtFiltrar.TabIndex = 10;
            this.txtFiltrar.Visible = false;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // lblServici
            // 
            this.lblServici.AutoSize = true;
            this.lblServici.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServici.ForeColor = System.Drawing.Color.Black;
            this.lblServici.Location = new System.Drawing.Point(90, 9);
            this.lblServici.Name = "lblServici";
            this.lblServici.Size = new System.Drawing.Size(83, 23);
            this.lblServici.TabIndex = 8;
            this.lblServici.Text = "Servicio";
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
            this.pBotones.Location = new System.Drawing.Point(0, 40);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(94, 548);
            this.pBotones.TabIndex = 1;
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // pGrid
            // 
            this.pGrid.BackColor = System.Drawing.Color.Transparent;
            this.pGrid.Controls.Add(this.pNuevo);
            this.pGrid.Controls.Add(this.dataGridView1);
            this.pGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrid.Location = new System.Drawing.Point(94, 40);
            this.pGrid.Name = "pGrid";
            this.pGrid.Size = new System.Drawing.Size(839, 548);
            this.pGrid.TabIndex = 2;
            // 
            // pNuevo
            // 
            this.pNuevo.BackgroundImage = global::HospitalRegionalIca.Properties.Resources.main_bg07;
            this.pNuevo.Controls.Add(this.lblDepartamento);
            this.pNuevo.Controls.Add(this.cmbDepartamento);
            this.pNuevo.Controls.Add(this.txtServicio);
            this.pNuevo.Controls.Add(this.lblServicio);
            this.pNuevo.Controls.Add(this.lblIdServicio);
            this.pNuevo.Location = new System.Drawing.Point(30, 21);
            this.pNuevo.Name = "pNuevo";
            this.pNuevo.Size = new System.Drawing.Size(514, 138);
            this.pNuevo.TabIndex = 5;
            this.pNuevo.Visible = false;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(10, 34);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(97, 17);
            this.lblDepartamento.TabIndex = 11;
            this.lblDepartamento.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(130, 30);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(296, 25);
            this.cmbDepartamento.TabIndex = 9;
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(130, 61);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(296, 22);
            this.txtServicio.TabIndex = 6;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(30, 64);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(57, 17);
            this.lblServicio.TabIndex = 5;
            this.lblServicio.Text = "Servicio";
            // 
            // lblIdServicio
            // 
            this.lblIdServicio.AutoSize = true;
            this.lblIdServicio.Location = new System.Drawing.Point(406, 10);
            this.lblIdServicio.Name = "lblIdServicio";
            this.lblIdServicio.Size = new System.Drawing.Size(20, 17);
            this.lblIdServicio.TabIndex = 4;
            this.lblIdServicio.Text = "ID";
            this.lblIdServicio.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(725, 430);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalRegionalIca.Properties.Resources.main_bg08;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.pGrid);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.pTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmServicio";
            this.Text = "Servicio";
            this.Load += new System.EventHandler(this.frmServicio_Load);
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
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Panel pGrid;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblServici;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pNuevo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblIdServicio;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btnGuardar;
    }
}