using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Soporte.Cache;

namespace Sistemas_Reservas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        NUsuarios usu = new NUsuarios();
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void CargarPerfil()
        {
            if (picInicio.Image == null)
            {
                picInicio.Image = Sistemas_Reservas.Properties.Resources.usuario;
            }
            else
            {

                try
                {
                    MemoryStream ms = new MemoryStream(usu.Foto(cache_usuario.Id_usuario));
                    picInicio.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {


                }
            }

            lblNombreApp.Text = cache_usuario.nombre + " " + cache_usuario.apellido;
            lblUsuarioApp.Text = cache_usuario.usuario;
            lblEmailApp.Text = cache_usuario.email;


        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelContenedor.Controls.Add(formulario);
                PanelContenedor.Tag = formulario;
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
            if (Application.OpenForms["Clientes"] == null) { }
            // btnClientes.BackColor = Color.FromArgb(186, 196, 200);
            if (Application.OpenForms["Canchas"] == null) { }
            //btnCanchas.BackColor = Color.FromArgb(186, 196, 200);
            if (Application.OpenForms["Reservas"] == null) { }
            //btnReservas.BackColor = Color.FromArgb(186, 196, 200);

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Clientes>();

        }

        private void btnCanchas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Canchas>();

        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Reservas>();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult cons;
            cons = MessageBox.Show("¿Desea Cerrar la Aplicacion?", "Sistema de Reservas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cons == DialogResult.Yes)
                Application.Exit();
        }
        int LY, LX, SW, SH;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            LY = this.Location.Y;
            LX = this.Location.X;
            SW = this.Width;
            SH = this.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            CargarPerfil();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult cons;
            cons = MessageBox.Show("¿Desea Cerrar la Aplicacion?", "Sistema de Reservas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cons == DialogResult.Yes)
            {
                usu.Hora_Salida1(cache_usuario.Id_usuario);
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void linkEditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormulario<EditarPerfil>();
        }
    }
}
