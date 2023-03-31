using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReservas:Conexion
    {
        public DataTable MostrarHorariosReservas(DateTime fecha,string numero)
        { 
            using(var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "MostrarHorarioReserva";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public DataTable MostrarCanchas()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_MostrarCanchas";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public DataTable DetallesCanchas()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_DetallesCanchas";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public DataTable MostrarHorarios()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_MostrarHorarios";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public DataTable MostrarClientes()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_Mostrar_Clientes";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public int TotalAPagar(int id_reserva,string numero,DateTime fecha)
        {
            int cant;
            using (var conetion = GetConnection())
            {

                conetion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conetion;
                    cmd.CommandText = "Sp_TotalAPagar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_reserva", id_reserva);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.Add("@Total", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    cant = Convert.ToInt32(cmd.Parameters["@Total"].Value.ToString());


                }

            }
            return cant;
        }
        public string AgregarReservas(int id_cliente, int id_cancha, int id_horario, DateTime fecha, bool concluido,decimal anticipo)
        {
            string resp = string.Empty;
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "AgregarReserva";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
                    cmd.Parameters.Add("@id_cancha", SqlDbType.Int).Value = id_cancha;
                    cmd.Parameters.Add("@id_horario", SqlDbType.Int).Value = id_horario;
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                    cmd.Parameters.Add("@concluido", SqlDbType.Bit).Value = concluido;
                    cmd.Parameters.Add("@anticipo", SqlDbType.Decimal).Value = anticipo;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    resp = cmd.Parameters["@mensaje"].Value.ToString();

                    return resp;
                }
            }

        }
        public void EditarReserva(int id_reserva ,bool concluido)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_EditarReserva";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_reserva", id_reserva);
                    cmd.Parameters.AddWithValue("@concluido", concluido);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        public void EliminarReserva(int id_reserva)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_EliminarReserva";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_reserva", id_reserva);

                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
