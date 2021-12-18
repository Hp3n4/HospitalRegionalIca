
namespace HospitalRegionalIca
{
    partial class frmPersonal
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
            this.pBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ptitulo = new System.Windows.Forms.Panel();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.pBotones.SuspendLayout();
            this.pGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ptitulo.SuspendLayout();
            this.SuspendLayout();
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
            this.pBotones.Location = new System.Drawing.Point(0, 0);
            this.pBotones.Margin = new System.Windows.Forms.Padding(4);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(100, 465);
            this.pBotones.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::HospitalRegionalIca.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(13, 378);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 65);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::HospitalRegionalIca.Properties.Resources.Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(13, 305);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(74, 65);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::HospitalRegionalIca.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(13, 232);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 65);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::HospitalRegionalIca.Properties.Resources.Eliminar;
            this.btneliminar.Location = new System.Drawing.Point(12, 159);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(74, 65);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::HospitalRegionalIca.Properties.Resources.Actualizar;
            this.btnModificar.Location = new System.Drawing.Point(13, 86);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 65);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::HospitalRegionalIca.Properties.Resources.Nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(13, 13);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(74, 65);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // pGrid
            // 
            this.pGrid.BackColor = System.Drawing.Color.Transparent;
            this.pGrid.Controls.Add(this.dataGridView1);
            this.pGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrid.Location = new System.Drawing.Point(100, 0);
            this.pGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pGrid.Name = "pGrid";
            this.pGrid.Size = new System.Drawing.Size(833, 465);
            this.pGrid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(777, 400);
            this.dataGridView1.TabIndex = 1;
            // 
            // ptitulo
            // 
            this.ptitulo.BackColor = System.Drawing.Color.Transparent;
            this.ptitulo.Controls.Add(this.lblPersonal);
            this.ptitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptitulo.Location = new System.Drawing.Point(100, 0);
            this.ptitulo.Name = "ptitulo";
            this.ptitulo.Size = new System.Drawing.Size(833, 37);
            this.ptitulo.TabIndex = 2;
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonal.ForeColor = System.Drawing.Color.Black;
            this.lblPersonal.Location = new System.Drawing.Point(12, 7);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(88, 23);
            this.lblPersonal.TabIndex = 6;
            this.lblPersonal.Text = "Personal";
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalRegionalIca.Properties.Resources.main_bg08;
            this.ClientSize = new System.Drawing.Size(933, 465);
            this.Controls.Add(this.ptitulo);
            this.Controls.Add(this.pGrid);
            this.Controls.Add(this.pBotones);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPersonal";
            this.Text = "Personal";
            this.pBotones.ResumeLayout(false);
            this.pGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ptitulo.ResumeLayout(false);
            this.ptitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Panel pGrid;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel ptitulo;
        private System.Windows.Forms.Label lblPersonal;
    }
}