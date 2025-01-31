using Soporte.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace Sistemas_Reservas
{
    public partial class EditarPerfil : Form
    {
        public EditarPerfil()
        {
            InitializeComponent();
        }


        #region "Funciones"
        NUsuarios usu = new NUsuarios();
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CargarPerfil()
        {
            lblUsuarioApp.Text = cache_usuario.usuario;
            lblNombreApp.Text = cache_usuario.nombre;
            lblApllidoApp.Text = cache_usuario.apellido;
            lblEmailApp.Text = cache_usuario.email;


            if (picPerfil.Image == null)
            {
                try
                {
                    MemoryStream ms = new MemoryStream(usu.Foto(cache_usuario.Id_usuario));
                    picPerfil.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {


                }
            }
         


            txtUsuario.Text = cache_usuario.usuario;
            txtNombre.Text = cache_usuario.nombre;
            txtApellido.Text = cache_usuario.apellido;
            txtEmail.Text = cache_usuario.email;
            txtContraseña.Text = cache_usuario.contraseña;
            txtConfirmarContraseña.Text = cache_usuario.contraseña;
            txtContraseñaActual.Text = "";

        }
        private void InizializePassEditControls()
        {
            linkCambiarContraseña.Text = "Cambiar";
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.Enabled = false;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
            txtConfirmarContraseña.Enabled = false;
            txtContraseñaActual.UseSystemPasswordChar = true;
        }
        private void Reset()
        {
            CargarPerfil();
            InizializePassEditControls();
        }
        #endregion

        #region "Eventos"
        private void linkEditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pDatos.Visible == false)
            {
                pDatos.Visible = true;
                btnAgregarImagen.Visible = true;
            }
            else
            {
                pDatos.Visible = false;
                btnAgregarImagen.Visible = false;
            }
        }

        #endregion
        bool Cambiar = false;
        private void linkCambiarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (linkCambiarContraseña.Text == "Cambiar")
            {
                linkCambiarContraseña.Text = "Cancelar";
                txtContraseña.Enabled = true;
                txtContraseña.Text = string.Empty;
                txtConfirmarContraseña.Text = string.Empty;
                txtConfirmarContraseña.Enabled = true;
                Cambiar = true;
            }
            else if (linkCambiarContraseña.Text == "Cancelar")
            {
                Reset();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string pass = Seguridad.Encriptar(txtContraseñaActual.Text);
            if (txtContraseña.Text == txtConfirmarContraseña.Text)//primero valida que la contraseñas coincidan
            {
                if (pass == cache_usuario.contraseña)//esto valida para terminar de hacer los cambios
                {
                    if (Cambiar)
                    {

                        MemoryStream ms = new MemoryStream();
                        picPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        var User = new NUsuarios(id_usuario: cache_usuario.Id_usuario, nombre: txtNombre.Text, apellido: txtApellido.Text, usuario: txtUsuario.Text, contraseña: Seguridad.Encriptar(txtContraseña.Text), email: txtEmail.Text, imagen: ms.GetBuffer());
                        var result = User.EditarPerfil();
                        usu.Foto(cache_usuario.Id_usuario);
                        MensajeOK(result);
                        txtContraseñaActual.Text = string.Empty;
                    }
                    else
                    {

                        MemoryStream ms = new MemoryStream();
                        picPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        string descrip = txtContraseña.Text;
                        var User = new NUsuarios(id_usuario: cache_usuario.Id_usuario, nombre: txtNombre.Text, apellido: txtApellido.Text, usuario: txtUsuario.Text, contraseña: descrip, email: txtEmail.Text, imagen: ms.GetBuffer());
                        var result = User.EditarPerfil();
                        usu.Foto(cache_usuario.Id_usuario);
                        MensajeOK(result);
                        txtContraseñaActual.Text = string.Empty;
                    }

                }
                else
                {
                    MensajeError("Contraseña Actual Incorrecta");
                }
            }
            else
            {
                MensajeError("Las Contraseñas que ingreso no coinciden");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult dr = fo.ShowDialog();

            if (dr == DialogResult.OK)
            {
                picPerfil.Image = Image.FromFile(fo.FileName);
            }
        }

        private void EditarPerfil_Load(object sender, EventArgs e)
        {
            CargarPerfil();
            InizializePassEditControls();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
