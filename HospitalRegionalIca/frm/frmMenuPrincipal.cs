using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace HospitalRegionalIca
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            pSubMenuReportes.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pSubMenuReportes.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pSubMenuReportes.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pSubMenuReportes.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar la Aplicacion?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Dispose();
                //Application.Exit();
        }


        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pContenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pContenedor.Controls.Add(formulario);
                pContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            //if (Application.OpenForms["frmDashboard"] == null)
               // button1.BackColor = Color.FromArgb(4, 41, 68);
            //if (Application.OpenForms["Form2"] == null)
            //    button2.BackColor = Color.FromArgb(4, 41, 68);
            //if (Application.OpenForms["Form3"] == null)
            //    button3.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDashboard>();
        }
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
            timer1.Enabled = true;
            LoadUserData();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void LoadUserData()
        {
            clsUsuarioAcceder objUsuarioAcceder = new clsUsuarioAcceder();
            clsUsuarioConexion objUsuarioConexion = new clsUsuarioConexion();
            lblUsuario.Text = objUsuarioAcceder.ApellidoPaterno + " " + objUsuarioAcceder.ApellidoMaterno + " " + objUsuarioAcceder.Nombres;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPersonal>();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPersonal>();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDepartamento>();
        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmServicio>();
        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmTurno>();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmUsuario>();
        }

        private void sToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDocumento>();
        }

        private void trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmTrabajador>();
        }
    }
}
