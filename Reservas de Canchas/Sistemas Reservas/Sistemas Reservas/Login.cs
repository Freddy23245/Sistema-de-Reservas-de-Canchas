using Soporte.Cache;
using Negocio;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sistemas_Reservas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region "Funciones"
        NUsuarios usu = new NUsuarios();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void msgError(string str)
        {
            lblErrorMensaje.Text = "    " + str;
            lblErrorMensaje.Visible = true;
        }
        public void CargarPerfil()
        {
            if (picLogin.Image == null)
            {

                //  picLogin.Image = Sistemas_Reservas.Properties.Resources.usuario;
                try
                {
                    MemoryStream ms = new MemoryStream(usu.FotoLogin(txt_usuario.Text));
                    picLogin.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {


                }
            }
            else
            {
                picLogin.Image = Sistemas_Reservas.Properties.Resources.usuario;
            }


        }
        #endregion

        #region "Eventos"
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text != "USUARIO")
            {
                if (txt_contraseņa.Text != "CONTRASEŅA")
                {

                    var userLog = usu.LoginUser(txt_usuario.Text, Seguridad.Encriptar(txt_contraseņa.Text));


                    if (userLog == true)
                    {
                        if (!Convert.ToBoolean(cache_usuario.habilitado))
                        {
                            msgError("El usuario esta bloqueado por que accedio " + Environment.NewLine + "    3 veces la Contraseņa incorrecta");
                        }
                        else
                        {
                            usu.Hora_Ingreso1(cache_usuario.Id_usuario);
                            usu.IngresoUsuario(cache_usuario.Id_usuario);
                            Inicio ini = new Inicio();
                            ini.Show();
                            this.Hide();

                        }

                    }
                    else
                    {

                        msgError("El usuario o la contraseņa ingresada son incorrectas");
                        usu.IntentoPass(txt_usuario.Text, Seguridad.Encriptar(txt_contraseņa.Text));
                        txt_contraseņa.Clear();
                        txt_usuario.Focus();
                    }
                }
                else
                {
                    msgError("Por favor Ingrese la Contraseņa");
                }
            }
            else
            {
                msgError("Por favor ingrese el usuario");
            }


        }



        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            picLogin.Image = null;
            CargarPerfil();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.Text = "Sistema Gestor " + Environment.NewLine + "de Reservas de Canchas";
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "USUARIO")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.Black;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "USUARIO";
                txt_usuario.ForeColor = Color.DimGray;

            }
        }

        private void txt_contraseņa_Enter(object sender, EventArgs e)
        {
            if (txt_contraseņa.Text == "CONTRASEŅA")
            {
                txt_contraseņa.Text = "";
                txt_contraseņa.ForeColor = Color.Black;
                txt_contraseņa.UseSystemPasswordChar = true;
            }
        }

        private void txt_contraseņa_Leave(object sender, EventArgs e)
        {
            if (txt_contraseņa.Text == "")
            {
                txt_contraseņa.Text = "CONTRASEŅA";
                txt_contraseņa.ForeColor = Color.DimGray;
                txt_contraseņa.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar_Contraseņa rec = new Recuperar_Contraseņa();
            rec.Show();
        }
    }
}