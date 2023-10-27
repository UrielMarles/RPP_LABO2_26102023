using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public Moto(Epropulsion propulsion):base(propulsion){ }

        protected override string Tipo
        {
            get
            {
                return "Moto";
            }
        }
    }
}
