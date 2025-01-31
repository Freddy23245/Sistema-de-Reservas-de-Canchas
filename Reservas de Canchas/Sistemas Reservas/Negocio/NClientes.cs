using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class NClientes
    {
        DClientes cli = new DClientes();

        public DataTable Mostrar()
        {
            return cli.MostrarCliente();
        }

        public void AgregarClientes(string nombre, string apellido, string telefono, bool fijo)
        {
            cli.AgregarClientes(nombre, apellido, telefono, fijo);
        }
        public void EditarClientes(int id_cliente, string nombre, string apellido, string telefono, bool fijo)
        {
            cli.EditarClientes(id_cliente, nombre, apellido, telefono, fijo);
        }
        public void EliminarClientes(int id_cliente)
        {
            cli.EliminarClientes(id_cliente);
        }


    }
}
