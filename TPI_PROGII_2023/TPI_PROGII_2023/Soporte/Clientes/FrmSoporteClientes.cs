using InmobiliariaBack.Datos;
using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Dominio;
using InmobiliariaBack.Dominio.Alquileres;
using InmobiliariaBack.Dominio.Contactos;
using InmobiliariaBack.Dominio.Persona;
using InmobiliariaBack.DTO;
using InmobiliariaFront.Client;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmobiliariaFront.Soporte.Clientes
{
    public partial class FrmSoporteClientes : Form
    {
        public FrmSoporteClientes()
        {
            InitializeComponent();
        }
        private async void FrmSoporteClientes_Load(object sender, EventArgs e)
        {
            await CargarDataGridView();
        }

        private async Task<List<Barrio>> ObtenerBarrios()
        {
            List<Barrio> listaBarrios = new List<Barrio>();

            try
            {
                string url = "https://localhost:7027/api/Barrio/barrios";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    listaBarrios = JsonConvert.DeserializeObject<List<Barrio>>(response);
                }
                else
                {
                    MessageBox.Show("La respuesta de la API está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaBarrios;
        }

        private async Task CargarDataGridView()
        {
            try
            {
                string url = "https://localhost:7027/api/Cliente/clientes";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    List<Cliente> listaClientes = JsonConvert.DeserializeObject<List<Cliente>>(response);
                    List<Barrio> listaBarrios = await ObtenerBarrios();

                    dgvClientes.Rows.Clear();

                    foreach (Cliente oCliente in listaClientes)
                    {
                        Barrio oBarrio = new Barrio();
                        foreach (Barrio b in listaBarrios)
                        {
                            if (b.CodBarrio == oCliente.Barrio.CodBarrio)
                                oBarrio = b;
                        }
                        dgvClientes.Rows.Add(new object[] {
                            oCliente.CodCliente,
                            oCliente.Nombre,
                            oCliente.Apellido,
                            oCliente.FechaNacimiento,
                            oCliente.Documento,
                            oCliente.Cuil,
                            oCliente.FechaRegistro,
                            oBarrio,
                            oCliente.Direccion,
                            oCliente.NroDireccion
                        });
                    }
                }
                else
                {
                    MessageBox.Show("La respuesta de la API está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void ActualizarDataGridView()
        {
            await CargarDataGridView();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCreateUpdateCliente frmCreateUpdate = new FrmCreateUpdateCliente(true, new Cliente());
            frmCreateUpdate.Owner = this;
            frmCreateUpdate.ShowDialog();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de que desea eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int codCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["CodCliente"].Value);
                    string url = $"https://localhost:7027/api/Cliente/eliminar-cliente/{codCliente}";

                    string response = await ClienteSingleton.GetInstance().DeleteAsync(url);

                    if (!string.IsNullOrEmpty(response))
                    {
                        MessageBox.Show("El cliente se eliminó con éxito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La respuesta de la API está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ActualizarDataGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente(
                Convert.ToInt32(dgvClientes.CurrentRow.Cells["CodCliente"].Value),
                Convert.ToInt32(dgvClientes.CurrentRow.Cells["ColDocumento"].Value),
                Convert.ToString(dgvClientes.CurrentRow.Cells["ColNombre"].Value),
                Convert.ToString(dgvClientes.CurrentRow.Cells["ColApellido"].Value),
                Convert.ToString(dgvClientes.CurrentRow.Cells["ColCuil"].Value),
                new Barrio(),
                Convert.ToString(dgvClientes.CurrentRow.Cells["ColDireccion"].Value),
                Convert.ToInt32(dgvClientes.CurrentRow.Cells["ColNroDireccion"].Value),
                Convert.ToDateTime(dgvClientes.CurrentRow.Cells["ColFechaRegistro"].Value),
                Convert.ToDateTime(dgvClientes.CurrentRow.Cells["ColFechaNacimiento"].Value),
                new List<Contacto>(),
                new List<Alquiler>()
            );

            FrmCreateUpdateCliente frmCreateUpdate = new FrmCreateUpdateCliente(false, oCliente);
            frmCreateUpdate.Owner = this;
            frmCreateUpdate.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea abandonar esta pestaña?"
                 , "Volver al inicio"
                 , MessageBoxButtons.YesNo
                 , MessageBoxIcon.Question
                 , MessageBoxDefaultButton.Button2)
                 == DialogResult.Yes)
                Close();
        }
    }

}
