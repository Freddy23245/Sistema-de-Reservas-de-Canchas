using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class NReservas
    {
        DReservas reserva = new DReservas();
        public DataTable Mostrar(DateTime fecha,string numero)
        {
            DataTable dt = new DataTable();
            dt = reserva.MostrarHorariosReservas(fecha,numero);
            return dt;
        }
        public decimal TotalAPAgar(int id_reserva,string numero,DateTime fecha)
        {
            return reserva.TotalAPagar(id_reserva,numero,fecha);
        }
        public DataTable MostrarClientes()
        {
            DataTable dtClientes = new DataTable();
            dtClientes = reserva.MostrarClientes();
            return dtClientes;
        }
        public DataTable DetallesCanchas()
        {
            DataTable dtDetalles = new DataTable();
            dtDetalles = reserva.DetallesCanchas();
            return dtDetalles;
        }
        public DataTable MostrarHorarios()
        {
            DataTable dtHorarios = new DataTable();
            dtHorarios = reserva.MostrarHorarios();
            return dtHorarios;
        }
        public DataTable MostrarCanchas()
        {
            DataTable dtCanchas = new DataTable();
            dtCanchas = reserva.MostrarCanchas();
            return dtCanchas;
        }
        public string AgregarReserva(int id_cliente, int id_cancha, int id_horario, DateTime fecha, bool concluido,decimal anticipo)
        {
            string resp = string.Empty;
            resp = reserva.AgregarReservas(id_cliente, id_cancha, id_horario, fecha, concluido,anticipo);
            return resp;
        }
        public void EditarReserva(int id_reserva,bool concluido)
        {
            reserva.EditarReserva(id_reserva, concluido);
        }
        public void EliminarReserva(int id_reserva)
        {
            reserva.EliminarReserva(id_reserva);
        }


    }
}
