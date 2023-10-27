using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        public Automovil() : base(Epropulsion.Hibrida) { }

        protected override string Tipo
        {
            get
            {
                return "Automovil";
            }
        }
    }
}
