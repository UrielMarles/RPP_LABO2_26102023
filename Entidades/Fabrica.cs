using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public List<Vehiculo> Vehiculos
        {
            get { return this.vehiculos; }
        }

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Fabrica(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public static Fabrica operator +(Fabrica f, Vehiculo v)
        {
            if(f.vehiculos.Count < f.capacidad)
            {
                f.vehiculos.Add(v);
            }
            return f;
        }

        /// <summary>
        /// Saca un vehículo específico de la lista de vehículos de la fábrica, usa el operador sobrecargado == y se asegura que ambos tengan
        /// la misma chasis y que sean del mismo tipo
        /// </summary>
        /// <param name="f">La instancia de la fábrica de la que se eliminará el vehículo.</param>
        /// <param name="vehiculoSacar">El vehículo que se desea eliminar de la fábrica.</param>
        /// <returns>La instancia de la fábrica actualizada después de la eliminación del vehículo, en caso de que no se haya eliminado
        /// se devuelve igual.</returns>
        public static Fabrica operator -(Fabrica f, Vehiculo vehiculoSacar)
        {
            foreach(Vehiculo vehiculoViejo in f.vehiculos)
            {
                if (vehiculoSacar == vehiculoViejo)
                {
                    f.vehiculos.Remove(vehiculoViejo);
                    break;
                }
            }
            return f;
        }
    }
}
