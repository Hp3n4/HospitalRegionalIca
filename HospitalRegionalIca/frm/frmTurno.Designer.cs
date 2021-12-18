namespace HospitalRegionalIca
{
    partial class frmTurno
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
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.pBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ptitulo.SuspendLayout();
            this.pBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptitulo
            // 
            this.ptitulo.BackColor = System.Drawing.Color.Transparent;
            this.ptitulo.Controls.Add(this.lblDepartamento);
            this.ptitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptitulo.Location = new System.Drawing.Point(0, 0);
            this.ptitulo.Margin = new System.Windows.Forms.Padding(4);
            this.ptitulo.Name = "ptitulo";
            this.ptitulo.Size = new System.Drawing.Size(933, 38);
            this.ptitulo.TabIndex = 1;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.Black;
            this.lblDepartamento.Location = new System.Drawing.Point(86, 9);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(58, 23);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Turno";
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.Color.Transparent;
            this.pBotones.Controls.Add(this.btnSalir);
            this.pBotones.Controls.Add(this.btnImprimir);
            this.pBotones.Controls.Add(this.btnBuscar);
            this.pBotones.Controls.Add(this.btneliminar);
            this.pBotones.Controls.Add(this.btnModificar);
            this.pBotones.Controls.Add(this.btnNuevo);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBotones.Location = new System.Drawing.Point(0, 38);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(90, 550);
            this.pBotones.TabIndex = 2;
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(90, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 550);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(510, 430);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalRegionalIca.Properties.Resources.main_bg08;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.ptitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truno";
            this.ptitulo.ResumeLayout(false);
            this.ptitulo.PerformLayout();
            this.pBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ptitulo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}