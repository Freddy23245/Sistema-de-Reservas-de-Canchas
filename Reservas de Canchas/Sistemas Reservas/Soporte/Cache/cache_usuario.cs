using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
    public static class cache_usuario
    {
        public static int Id_usuario { get; set; }
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static string usuario { get; set; }
        public static string contraseña { get; set; }
        public static int intentopass { get; set; }
        public static int habilitado { get; set; }
        public static string email { get; set; }
        public static byte imagen { get; set; }
    }
}