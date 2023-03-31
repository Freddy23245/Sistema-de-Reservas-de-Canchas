using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_Reservas
{
    public partial class Canchas : Form
    {
        public Canchas()
        {
            InitializeComponent();
        }
        NCanchas cancha = new NCanchas();
        NReservas reservas = new NReservas();
        #region "Funciones"

        private void Mostrar()
        {
            DataTable dt = new DataTable();
            dt = reservas.MostrarCanchas();
            dt_canchas.DataSource = dt;
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

        #endregion

        #region "Eventos"
        private void Canchas_Load(object sender, EventArgs e)
        {
            Mostrar();
            lblId_cancha.Text = string.Empty;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(txtCapacidad.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MensajeError("Por favor Asegurese de que los campos esten completos");
            }
            else
            {
                cancha.AgregarCancha(txtNumero.Text, Convert.ToInt32(txtCapacidad.Text), Convert.ToDecimal(txtPrecio.Text));
                MensajeOk("Datos Agregados Correctamente");
                Mostrar();

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId_cancha.Text))
            {
                MensajeError("Por favor seleccione el registro a modificar");
            }
            else if (string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(txtCapacidad.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MensajeError("Por favor Asegurese de que los campos esten completos");
            }
            else
            {
                cancha.EditarCancha(Convert.ToInt32(lblId_cancha.Text), txtNumero.Text, Convert.ToInt32(txtCapacidad.Text), Convert.ToDecimal(txtPrecio.Text));
                MensajeOk("Datos Modificados Correctamente");
                Mostrar();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId_cancha.Text))
            {
                MensajeError("Por favor seleccione el registro a eliminar");
            }
            else
            {
                cancha.EliminarCanchas(Convert.ToInt32(lblId_cancha.Text));
                MensajeOk("Datos Eliminados Correctamente");
                Mostrar();
            }
        }
        private void dt_canchas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblId_cancha.Text = Convert.ToString(dt_canchas.CurrentRow.Cells["Id_Cancha"].Value);
            this.txtNumero.Text = Convert.ToString(dt_canchas.CurrentRow.Cells["Numero"].Value);
            this.txtCapacidad.Text = Convert.ToString(dt_canchas.CurrentRow.Cells["Capacidad"].Value);
            this.txtPrecio.Text = Convert.ToString(dt_canchas.CurrentRow.Cells["Precio"].Value);
        }
        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            if (txtNumero.Text.Length > 0)
                errorCanchas.SetError(txtNumero, "");
            else
                errorCanchas.SetError(txtNumero, "El Numero esta vacio");
        }

        private void txtCapacidad_Validating(object sender, CancelEventArgs e)
        {
            if (txtCapacidad.Text.Length > 0)
                errorCanchas.SetError(txtCapacidad, "");
            else
                errorCanchas.SetError(txtCapacidad, "La capacidd esta vacia");
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrecio.Text.Length > 0)
                errorCanchas.SetError(txtPrecio, "");
            else
                errorCanchas.SetError(txtPrecio, "El precio esta vacio");
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                decimal d3 = decimal.Parse("0");
                txtPrecio.Text = d3.ToString("0.00");
            }
            else
            {
                decimal d = Convert.ToDecimal(txtPrecio.Text);
                txtPrecio.Text = d.ToString("0.00");
            }


        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {

                errorCanchas.SetError(txtPrecio, "Solo se permiten numeros");
                e.Handled = true;
            }
        }
        #endregion







    }
}
