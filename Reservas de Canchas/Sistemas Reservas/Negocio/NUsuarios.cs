using Datos;
using Soporte.Cache;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsuarios
    {
        private int id_usuario;
        private string nombre;
        private string apellido;
        private string usuario;
        private string contraseña;
        private string email;
        private byte[] imagen;

        public NUsuarios(int id_usuario, string nombre, string apellido, string usuario, string contraseña, string email, byte[] imagen)
        {
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.email = email;
            this.imagen = imagen;
        }
        public NUsuarios()
        {

        }
        Dusuarios usuarios = new Dusuarios();

        public string EditarPerfil()
        {
            usuarios.EditarPerfil(id_usuario, nombre, apellido, usuario, contraseña, email, imagen);
            Foto(id_usuario);
            LoginUser(usuario, contraseña);

            return "Tu Perfil Se Edito Correctamente";

        }

        public byte[] Foto(int id_usuario)
        {
            return usuarios.mostrarFotoPerfil(id_usuario);
        }
        public byte[] FotoLogin(string usuario)
        {
            return usuarios.mostrarFotoLogin(usuario);
        }
        public bool LoginUser(string user, string pass)
        {
            return usuarios.Login(user, pass);
        }
        public void Hora_Ingreso1(int id_usuario)
        {
            usuarios.Hora_ingreso(id_usuario);
        }

        public void Hora_Salida1(int id_usuario)
        {
            usuarios.Hora_salida(id_usuario);
        }

        public string recoverPassword(string userRequesting)
        {

            var random = new Random();
            string var;
            var = Convert.ToString(random.Next(1000, 2000));
            usuarios.CambiarContraseña(userRequesting, Seguridad.Encriptar(var));
            return usuarios.recoverPassword(userRequesting);

        }

        public void IntentoPass(string usu, string pass)
        {
            usuarios.intento_pass(usu, pass);
        }
        public void IngresoUsuario(int id_usuario)
        {
            usuarios.ingreso_usuario(id_usuario);
        }

    }
}
