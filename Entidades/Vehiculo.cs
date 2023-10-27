namespace Entidades
{
    public enum Epropulsion {Combustion,Hibrida,Electrica}
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected Epropulsion propulsion;


        public Epropulsion Propulsion
        {
            get
            {
                return this.propulsion;
            }
        }

        protected abstract string Tipo
        {
            get;
        }

        protected Vehiculo(bool esAWD, Epropulsion epropulsion)
        {
            this.esAWD = esAWD;
            this.propulsion = epropulsion;
            this.numeroDeChasis = Guid.NewGuid();
        }

        protected Vehiculo(Epropulsion epropulsion): this(false, epropulsion) { }
        
        public static bool operator ==(Vehiculo v1,  Vehiculo v2)
        {
            return (v1.GetType()== v2.GetType() && v1.numeroDeChasis == v2.numeroDeChasis);
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        protected virtual string GetInfo()
        {
            string esAwdString = "No es AWD";
            if (this.esAWD)
            {
                esAwdString = "Si es Awd";
            }
            return string.Format("[{0}] con propulsión a {1} {2}, nummero de chasis {3}.", this.Tipo, this.propulsion, esAwdString, this.numeroDeChasis);
        }

        public override string ToString()
        {
            return GetInfo();
        }

    }
}