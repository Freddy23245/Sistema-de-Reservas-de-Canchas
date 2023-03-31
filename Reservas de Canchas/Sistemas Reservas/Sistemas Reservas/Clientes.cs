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
namespace Sistemas_Reservas
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        NClientes cli = new NClientes();
        #region "Funciones"
        private void Mostrar()
        {
            dt = cli.Mostrar();
            dt_clientes.DataSource = dt;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de reservas de Canchas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de reservas de Canchas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.chkFijo.Checked = false;
        }
        #endregion

        #region "Eventos"
        private void Clientes_Load(object sender, EventArgs e)
        {
            Mostrar();
            lblId_Cliente.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtTelefono.Text))

                MensajeError("Por favor asegurese de que los campos esten completos");
            else
            {
                cli.AgregarClientes(txtNombre.Text, txtApellido.Text, txtTelefono.Text, chkFijo.Checked);
                MensajeOk("Datos Agregados Correctamente");
                Limpiar();
                Mostrar();
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId_Cliente.Text))
            {
                MensajeError("Por favor Seleccione el registro a modificar");
            }
            else if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MensajeError("Por favor asegurese de que los campos esten completos");
            }
            else
            {
                cli.EditarClientes(int.Parse(lblId_Cliente.Text), txtNombre.Text, txtApellido.Text, txtTelefono.Text, chkFijo.Checked);
                MensajeOk("Datos modificados correctamente");
                Limpiar();
                Mostrar();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId_Cliente.Text))
            {
                MensajeError("Por favor seleccione el registro a eliminar");
            }
            else
            {
                cli.EliminarClientes(int.Parse(lblId_Cliente.Text));
                MensajeOk("Datos Eliminados Correctamente");
                Limpiar();
                Mostrar();
            }
        }
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Length > 0)
                errorCliente.SetError(txtNombre, "");
            else
                errorCliente.SetError(txtNombre, "El Nombre esta vacio");
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellido.Text.Length > 0)
            {
                errorCliente.SetError(txtApellido, "");
            }
            else
            {
                errorCliente.SetError(txtApellido, "El Apellido Esta Vacio");
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefono.Text.Length > 0)
                errorCliente.SetError(txtTelefono, "");
            else
                errorCliente.SetError(txtTelefono, "El telofono esta vacio");
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion





        private void dt_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblId_Cliente.Text = Convert.ToString(dt_clientes.CurrentRow.Cells["Id_Cliente"].Value);
            this.txtNombre.Text = Convert.ToString(dt_clientes.CurrentRow.Cells["Nombre"].Value);
            this.txtApellido.Text = Convert.ToString(dt_clientes.CurrentRow.Cells["Apellido"].Value);
            this.txtTelefono.Text = Convert.ToString(dt_clientes.CurrentRow.Cells["Telefono"].Value);
            this.chkFijo.Checked = Convert.ToBoolean(dt_clientes.CurrentRow.Cells["Fijo"].Value);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
