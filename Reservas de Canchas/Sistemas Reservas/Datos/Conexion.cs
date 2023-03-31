using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class Conexion
    {

        private readonly string Con;

        public Conexion() {

            Con = "Server = DESKTOP-UF3NIEQ; database = RESERVA_CANCHAS; integrated security = true";


        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Con);
        }

    }
}
