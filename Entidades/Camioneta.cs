using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;

        protected override string Tipo
        {
            get
            {
                return "Camioneta";
            }
        }

        public Camioneta(Epropulsion propulsion, bool cabinaSimple):base(false,propulsion) 
        { 
            this.cabinaSimple = cabinaSimple;
        }

        protected override string GetInfo()
        {
            string cabina = "doble";
            if (this.cabinaSimple)
            {
                cabina = "simple";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetInfo());
            sb.Append("Con cabina:");
            sb.Append(cabina);
            return sb.ToString();
        }

    }
}
