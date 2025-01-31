using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DCanchas : Conexion
    {



        public void AgregarCanchas(string numero, int capacidad, decimal precio)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_AgregarCanchas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@capacidad", capacidad);
                    cmd.Parameters.AddWithValue("@precio", precio);

                    cmd.ExecuteNonQuery();
                }

            }
        }
        public void EditarCanchas(int id_cancha,string numero, int capacidad, decimal precio)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_EditarCanchas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id_cancha", id_cancha);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@capacidad", capacidad);
                    cmd.Parameters.AddWithValue("@precio", precio);

                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void EliminarCanchas(int id_cancha)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_EliminarCancha";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cancha", id_cancha);
                

                    cmd.ExecuteNonQuery();
                }

            }
        }

    }
}
