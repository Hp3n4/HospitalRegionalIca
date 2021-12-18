namespace HospitalRegionalIca
{
    partial class frmDepartamento
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
            this.ptitulo = new System.Windows.Forms.Panel();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.pBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pNuevo = new System.Windows.Forms.Panel();
            this.lblIdDepartamento = new System.Windows.Forms.Label();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.lblJefe = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblDepartamentos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ptitulo.SuspendLayout();
            this.pBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptitulo
            // 
            this.ptitulo.BackColor = System.Drawing.Color.Transparent;
            this.ptitulo.Controls.Add(this.txtFiltrar);
            this.ptitulo.Controls.Add(this.lblDepartamento);
            this.ptitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptitulo.Location = new System.Drawing.Point(0, 0);
            this.ptitulo.Margin = new System.Windows.Forms.Padding(4);
            this.ptitulo.Name = "ptitulo";
            this.ptitulo.Size = new System.Drawing.Size(933, 38);
            this.ptitulo.TabIndex = 0;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(321, 8);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(294, 22);
            this.txtFiltrar.TabIndex = 8;
            this.txtFiltrar.Visible = false;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.Black;
            this.lblDepartamento.Location = new System.Drawing.Point(86, 9);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(145, 23);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Departamento";
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.Color.Transparent;
            this.pBotones.Controls.Add(this.btnSalir);
            this.pBotones.Controls.Add(this.btnImprimir);
            this.pBotones.Controls.Add(this.btnBuscar);
            this.pBotones.Controls.Add(this.btneliminar);
            this.pBotones.Controls.Add(this.btnModificar);
            this.pBotones.Controls.Add(this.btnGuardar);
            this.pBotones.Controls.Add(this.btnNuevo);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBotones.Location = new System.Drawing.Point(0, 38);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(90, 474);
            this.pBotones.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::HospitalRegionalIca.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(9, 381);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 65);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::HospitalRegionalIca.Properties.Resources.Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(9, 308);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(74, 65);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::HospitalRegionalIca.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(9, 235);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 65);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::HospitalRegionalIca.Properties.Resources.Eliminar;
            this.btneliminar.Location = new System.Drawing.Point(8, 162);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(74, 65);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::HospitalRegionalIca.Properties.Resources.Actualizar;
            this.btnModificar.Location = new System.Drawing.Point(9, 89);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 65);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::HospitalRegionalIca.Properties.Resources.Nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(9, 16);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(74, 65);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::HospitalRegionalIca.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(8, 16);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 65);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pNuevo);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(90, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 474);
            this.panel1.TabIndex = 2;
            // 
            // pNuevo
            // 
            this.pNuevo.BackgroundImage = global::HospitalRegionalIca.Properties.Resources.main_bg07;
            this.pNuevo.Controls.Add(this.lblIdDepartamento);
            this.pNuevo.Controls.Add(this.txtJefe);
            this.pNuevo.Controls.Add(this.lblJefe);
            this.pNuevo.Controls.Add(this.txtDepartamento);
            this.pNuevo.Controls.Add(this.lblDepartamentos);
            this.pNuevo.Location = new System.Drawing.Point(15, 16);
            this.pNuevo.Name = "pNuevo";
            this.pNuevo.Size = new System.Drawing.Size(510, 138);
            this.pNuevo.TabIndex = 3;
            this.pNuevo.Visible = false;
            // 
            // lblIdDepartamento
            // 
            this.lblIdDepartamento.AutoSize = true;
            this.lblIdDepartamento.Location = new System.Drawing.Point(406, 10);
            this.lblIdDepartamento.Name = "lblIdDepartamento";
            this.lblIdDepartamento.Size = new System.Drawing.Size(20, 17);
            this.lblIdDepartamento.TabIndex = 4;
            this.lblIdDepartamento.Text = "ID";
            this.lblIdDepartamento.Visible = false;
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new System.Drawing.Point(130, 58);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new System.Drawing.Size(296, 22);
            this.txtJefe.TabIndex = 3;
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Location = new System.Drawing.Point(82, 61);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(34, 17);
            this.lblJefe.TabIndex = 2;
            this.lblJefe.Text = "Jefe";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(130, 30);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(296, 22);
            this.txtDepartamento.TabIndex = 1;
            // 
            // lblDepartamentos
            // 
            this.lblDepartamentos.AutoSize = true;
            this.lblDepartamentos.Location = new System.Drawing.Point(19, 33);
            this.lblDepartamentos.Name = "lblDepartamentos";
            this.lblDepartamentos.Size = new System.Drawing.Size(97, 17);
            this.lblDepartamentos.TabIndex = 0;
            this.lblDepartamentos.Text = "Departamento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(695, 430);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalRegionalIca.Properties.Resources.main_bg08;
            this.ClientSize = new System.Drawing.Size(933, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.ptitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDepartamento";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.frmDepartamento_Load);
            this.ptitulo.ResumeLayout(false);
            this.ptitulo.PerformLayout();
            this.pBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pNuevo.ResumeLayout(false);
            this.pNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ptitulo;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pNuevo;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblDepartamentos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtJefe;
        private System.Windows.Forms.Label lblJefe;
        private System.Windows.Forms.Label lblIdDepartamento;
        private System.Windows.Forms.TextBox txtFiltrar;
    }
}