using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Soporte.Cache;
using System.Net.Mail;
namespace Datos
{
    public class Dusuarios:Conexion
    {
        public byte[] mostrarFotoPerfil(int id_usuario)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "FotoPerfil";
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    SqlDataAdapter dp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet("Usuarios");
                    byte[] MisDatos;

                    dp.Fill(ds, "Usuarios");

                    DataRow myRow = ds.Tables["Usuarios"].Rows[0];

                    if (myRow["imagen"] != DBNull.Value)
                    {
                        MisDatos = (byte[])myRow["imagen"];
                    }
                    else
                    {
                        return MisDatos = new byte[0];
                    }


                    return MisDatos;

                }
            }

        }
        public byte[] mostrarFotoLogin(string usuario)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "FotoPerfilLogin";
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    SqlDataAdapter dp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet("Usuarios");
                    byte[] MisDatos;

                    dp.Fill(ds, "Usuarios");

                    DataRow myRow = ds.Tables["Usuarios"].Rows[0];

                    if (myRow["imagen"] != DBNull.Value)
                    {
                        MisDatos = (byte[])myRow["imagen"];
                    }
                    else
                    {
                        return MisDatos = new byte[0];
                    }


                    return MisDatos;

                }
            }

        }

        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = "SP_login";
                    command.Parameters.AddWithValue("@usuario", user);
                    command.Parameters.AddWithValue("@pass", pass);

                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            cache_usuario.Id_usuario = reader.GetInt32(0);
                            cache_usuario.nombre = reader.GetString(1);
                            cache_usuario.apellido = reader.GetString(2);
                            cache_usuario.usuario = reader.GetString(3);
                            cache_usuario.contraseña = reader.GetString(4);
                            cache_usuario.intentopass = reader.GetInt32(5);
                            cache_usuario.habilitado = reader.GetInt32(6);
                            cache_usuario.email = reader.GetString(7);

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }

        }
        public void CambiarContraseña(string userRequesting, string var)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_Cambiarpass";
                    // cmd.Parameters.AddWithValue("@usuario", userRequesting);
                    cmd.Parameters.AddWithValue("@email", userRequesting);
                    cmd.Parameters.AddWithValue("@var", var);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "RecuperarContraseña";
                    // command.Parameters.AddWithValue("@usuario", userRequesting);
                    command.Parameters.AddWithValue("@email", userRequesting);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(1) + ", " + reader.GetString(2);
                        string userMail = reader.GetString(7);
                        string accountPassword = reader.GetString(4);
                        var random = new Random();

                        var passDesc = Seguridad.DesEncriptar(accountPassword);
                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                          subject: "Sistema de Reservas: Recuperacion de Contraseña",
                          body: "Hola, " + userName + " Tu solicitaste la recuperacion de tu contraseña" +
                          "Tu Contraseña es : " + passDesc +
                          " Recuerda Cambiar la contraseña cuando ingreses al sistema",
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hola, " + userName + "Tu solicitaste la recuperacion de tu contraseña" + Environment.NewLine +
                          "Por favor verifica tu email: " + userMail + Environment.NewLine +
                          "Recuerda Cambiar la contraseña cuando ingreses al sistema";



                    }
                    else
                        return "Por favor Verifica que el usuario o el email sean correctos";
                }
            }
        }
        public void EditarPerfil(int id_usuario, string nombre, string apellido, string usuario, string contraseña, string email, byte[] imagen)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "EditarPerfil";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@imagen", imagen);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Hora_ingreso(int id_usuario)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_IngresoLogin";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void Hora_salida(int id_usuario)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_SalidaLogin";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void intento_pass(string usuario, string pass)
        {
            using (var conection = GetConnection())
            {

                conection.Open();

                using (var cmd = new SqlCommand())
                {

                    cmd.Connection = conection;
                    cmd.CommandText = "SP_intentos_pass";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.ExecuteNonQuery();

                }

            }

        }
        public void ingreso_usuario(int id_usuario)
        {
            using (var conection = GetConnection())
            {

                conection.Open();

                using (var cmd = new SqlCommand())
                {

                    cmd.Connection = conection;
                    cmd.CommandText = "SP_ingreso_usuario";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                    cmd.ExecuteNonQuery();

                }


            }


        }



    }
}
