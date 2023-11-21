using InmobiliariaFront;
using InmobiliariaFront.Reportes;
using InmobiliariaFront.Soporte.Clientes;
using InmobiliariaFront.Soporte.Inmuebles;

namespace TPI_PROGII_2023
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPostPutCliente formGenerarFactura = new FrmPostPutCliente();
            formGenerarFactura.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void inquilinosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarClientesDeudores frmConsultarClientesDeudores = new FrmConsultarClientesDeudores();
            frmConsultarClientesDeudores.ShowDialog();
        }

        private void inmueblesCaptadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarInmueblesCaptados frmConsultarInmueblesCaptados = new FrmConsultarInmueblesCaptados();
            frmConsultarInmueblesCaptados.ShowDialog();
        }

        private void inmueblesDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarInmueblesDisponibles frmConsultarInmueblesDisponibles = new FrmConsultarInmueblesDisponibles();
            frmConsultarInmueblesDisponibles.ShowDialog();
        }

        private void promedioDeAlquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarPromediosAlquileres frmConsultarPromediosAlquileres = new FrmConsultarPromediosAlquileres();
            frmConsultarPromediosAlquileres.ShowDialog();
        }

        private void contratosPorFinalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarContratosPorFinalizar frmConsultarContratosPorFinalizar = new FrmConsultarContratosPorFinalizar();
            frmConsultarContratosPorFinalizar.ShowDialog();
        }

        private void inmueblesPorPropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarInmueblesPorProp frmConsultarInmueblesPorProp = new FrmConsultarInmueblesPorProp();
            frmConsultarInmueblesPorProp.ShowDialog();
        }

        private void inquilinosCumplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarClientesCumplidores frmConsultarClientesCumplidores = new FrmConsultarClientesCumplidores();
            frmConsultarClientesCumplidores.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSoporteClientes frmSoporteClientes = new FrmSoporteClientes();
            frmSoporteClientes.ShowDialog();
        }

        private void infoDesarrolloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcerca = new FrmAcercaDe();
            frmAcerca.ShowDialog();
        }

        private void inmueblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSoporteInmueble frmSoporteInmueble = new FrmSoporteInmueble();
            frmSoporteInmueble.ShowDialog();
        }
    }
}