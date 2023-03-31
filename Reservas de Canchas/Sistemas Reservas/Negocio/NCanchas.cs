using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCanchas
    {
        DCanchas cancha = new DCanchas();

        public void AgregarCancha(string numero,int capacidad,decimal precio)
        {
            cancha.AgregarCanchas(numero, capacidad, precio);
        }
        public void EditarCancha(int id_cancha, string numero, int capacidad, decimal precio)
        {
            cancha.EditarCanchas(id_cancha,numero,capacidad,precio);
        }
        public void EliminarCanchas(int id_cancha)
        {
            cancha.EliminarCanchas(id_cancha);
        }
    }
}
