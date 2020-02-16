using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Datos
    {
        private static List<Vehiculo> vehiculos;

        public List<Vehiculo> Vehiculos
        {
            get
            {
                if (vehiculos == null)
                {
                    vehiculos = new List<Vehiculo>();
                }
                return vehiculos;
            }


        }
    }
}
