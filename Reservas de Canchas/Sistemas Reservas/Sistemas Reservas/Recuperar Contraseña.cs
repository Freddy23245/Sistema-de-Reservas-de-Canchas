using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Negocio;
namespace Sistemas_Reservas
{
    public partial class Recuperar_Contraseña : Form
    {
        public Recuperar_Contraseña()
        {
            InitializeComponent();
        }

        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
            NUsuarios usu = new NUsuarios();
            var result = usu.recoverPassword(txtEmail.Text);
            lblResultado.Text = result;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
