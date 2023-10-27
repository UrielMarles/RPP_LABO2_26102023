using Entidades;
using System.Drawing.Text;

namespace RECUPPLABOURIEL
{
    public partial class FrmView : Form
    {
        private Fabrica fabrica;
        public FrmView()
        {
            InitializeComponent();
            InicializarFabrica();
            Refrescar();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = new object[] { "Automovil", "Camioneta", "Moto" };

        }
        private void InicializarFabrica()
        {
            this.fabrica = new Fabrica(23);
            this.fabrica += new Camioneta(Epropulsion.Electrica, true);

        }

        private void Refrescar()
        {
            this.lstVehiculos.DataSource = null;
            this.lstVehiculos.DataSource = fabrica.Vehiculos;
        }

        private Vehiculo CrearVehiculo()
        {
            switch (this.cmbTipo.SelectedIndex)
            {
                case 0:
                    return new Automovil();
                case 1:
                    return new Camioneta(Epropulsion.Hibrida, true);
                default:
                    return new Moto(Epropulsion.Electrica);
            }
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Vehiculo creado = CrearVehiculo();
            this.fabrica += creado;
            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int v = lstVehiculos.SelectedIndex;
            if (v >= 0)
            {
                Vehiculo vehiculo = this.fabrica.Vehiculos[v];
                this.fabrica -= vehiculo;
            }
            Refrescar();
        }
    }
}