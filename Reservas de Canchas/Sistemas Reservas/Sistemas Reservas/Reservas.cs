using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistemas_Reservas
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }
        NReservas Reserv = new NReservas();
        DataTable dtHora = new DataTable();
        bool concluido;
        #region "Funciones"

        private void MostrarClientes()
        {
            DataTable dtCli = new DataTable();
            dtCli = Reserv.MostrarClientes();
            cboClientes.DataSource = dtCli;
            cboClientes.DisplayMember = "Nombre";
            cboClientes.ValueMember = "Id_Cliente";
        }
        private void MostrarHorarios()
        {
            DataTable dtHorarios = new DataTable();
            dtHorarios = Reserv.MostrarHorarios();
            cboHorarios.DataSource = dtHorarios;
            cboHorarios.DisplayMember = "Hora";
            cboHorarios.ValueMember = "Id_Horario";
        }
        private void MostrarCanchas()
        {
            DataTable dtCancha = new DataTable();
           
           
            dtCancha = Reserv.MostrarCanchas();
            DataRow nuevaFila = dtCancha.NewRow();
            nuevaFila["Id_Cancha"] = 0;
            nuevaFila["Numero"] = "Seleccionar";
            dtCancha.Rows.InsertAt(nuevaFila, 0);
            cboCanchas.DataSource = dtCancha;
            cboCanchas.DisplayMember = "Numero";
            cboCanchas.ValueMember = "Id_Cancha";
        }
        private void DetallesCanchas()
        {
            DataTable dtCanchas = new DataTable();
            dtCanchas = Reserv.DetallesCanchas();
            ListCanchas.DataSource = dtCanchas;
            ListCanchas.DisplayMember = "Detalles";
            ListCanchas.ValueMember = "Id_Cancha";
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
            //cboCanchas.SelectedIndex = 0;
            //cboClientes.SelectedIndex = 0;
            //cboHorarios.SelectedIndex = 0;
            txtAnticipo.Text = "0.00";
            lblTotalAPAgar.Text = "";
        }
        private void CargarDatatable()
        {
            DateTime fecha = DateTime.Parse("15:00:00");

            dtHora.Columns.Add("Id");
            dtHora.Columns.Add("Horarios");
            for (int i = 0; i < 9; i++)
            {
                DataRow dr = dtHora.NewRow();

                dr["Horarios"] = fecha.ToString("HH:mm");

                dtHora.Rows.Add(dr);
                dtHora.AcceptChanges();
                fecha = fecha.AddHours(1);
            }
        }
        private void Mostrar(DateTime fecha, string numero)
        {
            DataTable dt = new DataTable();
            dt = Reserv.Mostrar(fecha, numero);
            #region "listbox"
            int item = 0;
            foreach (DataRow dr in dt.Rows)
            {
                string data = dr["Hora"].ToString();
                item = 0;
                foreach (DataRow row in dtHora.Rows)
                {
                    item++;
                    string data2 = row["Horarios"].ToString();

                    if (data != data2)
                    {
                        if (ListHorarios.Items.Contains(data2 + " - DISPONIBLE"))
                        {

                        }
                        else if (ListHorarios.Items.Contains(data2 + " - OCUPADO"))
                        {

                        }
                        else
                        {
                            ListHorarios.Items.Add(data2 + " - DISPONIBLE");
                        }


                    }
                    else
                    {
                        if (ListHorarios.Items.Contains(data2 + " - DISPONIBLE"))
                        {

                            ListHorarios.Items.Insert(item, data2 + " - OCUPADO");
                            ListHorarios.Items.RemoveAt(item - 1);
                        }
                        else
                        {
                            ListHorarios.Items.Add(data2 + " - OCUPADO");
                        }

                    }

                }

            }
            #endregion
            if(dt.Rows.Count > 0)
                dt_reservas.DataSource = dt;
            else
            {
                ListHorarios.Items.Add("Horarios Disponibles");
                dt_reservas.DataSource = null;
            }
        }
        private void LimpiarList()
        {
            ListHorarios.Items.Clear();
            chkConcluido.Checked = false;
        }
        #endregion
        private void Reservas_Load(object sender, EventArgs e)
        {
            CargarDatatable();
            MostrarCanchas();
            MostrarClientes();
            MostrarHorarios();
            DetallesCanchas();
            lblFecha.Text = string.Empty;
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblId_Reserva.Text = string.Empty;
            chkConcluido.Enabled = false;

        }

        private void mcFechas_DateSelected(object sender, DateRangeEventArgs e)
        {

            DateTime select = mcFechas.SelectionStart;
            lblFecha.Text = select.ToString("dd/MM/yyyy");
            LimpiarList();
            if(cboCanchas.Text != "Seleccionar")
                Mostrar(Convert.ToDateTime(lblFecha.Text), cboCanchas.Text);
            else
                MensajeError("Seleccione una cancha");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string resp = string.Empty;

            resp = Reserv.AgregarReserva(Convert.ToInt32(cboClientes.SelectedValue), Convert.ToInt32(cboCanchas.SelectedValue), Convert.ToInt32(cboHorarios.SelectedValue), Convert.ToDateTime(lblFecha.Text), false, Convert.ToDecimal(txtAnticipo.Text));
            MensajeOk(resp);
            LimpiarList();
            Limpiar();
            Mostrar(Convert.ToDateTime(lblFecha.Text), cboCanchas.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (concluido)
            {
                MensajeError("La Reserva ya esta concluida y no se puede eliminar");
            }
            else
            {
                if (string.IsNullOrEmpty(lblId_Reserva.Text))
                {
                    MensajeError("Por favor seleccione la reserva que desea eliminar");

                }
                else
                {
                    Reserv.EliminarReserva(int.Parse(lblId_Reserva.Text));
                    MensajeOk("Datos Eliminados Correctamente");
                    Limpiar();
                    LimpiarList();
                    Mostrar(Convert.ToDateTime(lblFecha.Text), cboCanchas.Text);
                }
            }
        }

        private void dt_reservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NReservas reserv = new NReservas();
            string numeroCancha = string.Empty;
            numeroCancha = Convert.ToString(dt_reservas.CurrentRow.Cells["Cancha"].Value);
            this.lblId_Reserva.Text = Convert.ToString(dt_reservas.CurrentRow.Cells["Id_Reserva"].Value);
            this.cboClientes.Text = Convert.ToString(dt_reservas.CurrentRow.Cells["Cliente"].Value);
            this.cboHorarios.Text = Convert.ToString(dt_reservas.CurrentRow.Cells["Hora"].Value);
            this.txtAnticipo.Text = Convert.ToString(dt_reservas.CurrentRow.Cells["Anticipo"].Value);
            concluido = Convert.ToBoolean(dt_reservas.CurrentRow.Cells["Concluido"].Value);
            decimal total = 0;
            total = reserv.TotalAPAgar(Convert.ToInt32(lblId_Reserva.Text), numeroCancha, Convert.ToDateTime(lblFecha.Text));
            lblTotalAPAgar.Text = " $ " + total.ToString();
            chkConcluido.Enabled = true;
            total = 0;
            

        }

        private void cboCanchas_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Mostrar(Convert.ToDateTime(lblFecha.Text), Convert.ToInt32(cboCanchas.Text));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId_Reserva.Text))
                MensajeError("Por favor seleccione el registro a modificar");
            else
            {
                Reserv.EditarReserva(Convert.ToInt32(lblId_Reserva.Text), chkConcluido.Checked);
                MensajeOk("Datos modificado correctamente");
                Limpiar();
                LimpiarList();
                Mostrar(Convert.ToDateTime(lblFecha.Text), cboCanchas.Text);
            }

        }

        private void txtAnticipo_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtAnticipo_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAnticipo_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnticipo.Text))
            {
                decimal d3 = decimal.Parse("0");
                txtAnticipo.Text = d3.ToString("0.00");
            }
            else
            {
                decimal d = Convert.ToDecimal(txtAnticipo.Text);
                txtAnticipo.Text = d.ToString("0.00");
            }
        }

        private void txtAnticipo_Click(object sender, EventArgs e)
        {
            txtAnticipo.Clear();
        }

        private void mcFechas_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txtAnticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {

                errorReserva.SetError(txtAnticipo, "Solo se permiten numeros");
                e.Handled = true;
            }
        }
    }
}
