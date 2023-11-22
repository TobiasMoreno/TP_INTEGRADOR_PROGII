using InmobiliariaBack.Dominio;
using InmobiliariaBack.Dominio.Alquileres;
using InmobiliariaBack.Dominio.Contactos;
using InmobiliariaBack.Dominio.Inmuebles;
using InmobiliariaBack.Dominio.Persona;
using InmobiliariaFront.Client;
using InmobiliariaFront.Soporte.Clientes;
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

namespace InmobiliariaFront.Soporte.Inmuebles
{
    public partial class FrmSoporteInmueble : Form
    {
        public FrmSoporteInmueble()
        {
            InitializeComponent();
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
        private async Task<List<TipoInmueble>> ObtenerTipoInmueble()
        {
            List<TipoInmueble> listaTipos = new List<TipoInmueble>();

            try
            {
                string url = "https://localhost:7027/api/TipoInmueble/tipo-inmuebles";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    listaTipos = JsonConvert.DeserializeObject<List<TipoInmueble>>(response);
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

            return listaTipos;
        }

        private async Task CargarDataGridView()
        {
            try
            {
                string url = "https://localhost:7027/api/Inmueble/inmuebles";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    List<Inmueble> listaInmuebles = JsonConvert.DeserializeObject<List<Inmueble>>(response);
                    List<Barrio> listaBarrios = await ObtenerBarrios();
                    List<TipoInmueble> listaTipos = await ObtenerTipoInmueble();

                    dgvInmuebles.Rows.Clear();

                    foreach (Inmueble oInmueble in listaInmuebles)
                    {
                        Barrio oBarrio = new Barrio();
                        foreach (Barrio b in listaBarrios)
                        {
                            if (b.CodBarrio == oInmueble.Barrio.CodBarrio)
                                oBarrio = b;
                        }
                        TipoInmueble oTipo = new TipoInmueble();
                        foreach (TipoInmueble tipo in listaTipos)
                        {
                            if (oTipo.CodTipoInmueble == oInmueble.TipoInmueble.CodTipoInmueble)
                                oTipo = tipo;
                        }
                        dgvInmuebles.Rows.Add(new object[] {
                            oInmueble.CodInmueble,
                            oInmueble.Superficie,
                            oInmueble.AñoConstruccion,
                            oInmueble.Descripcion,
                            oTipo.ValorTipoInmueble,
                            oBarrio,
                            oInmueble.Direccion,
                            oInmueble.NroDireccion,
                            oInmueble.Precio,
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
            FrmCreateUpdateInmueble frmCreateUpdate = new FrmCreateUpdateInmueble(true, new Inmueble());
            frmCreateUpdate.Owner = this;
            frmCreateUpdate.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            {
                Inmueble oInmueble = new Inmueble(
                    Convert.ToInt32(dgvInmuebles.CurrentRow.Cells["CodInmueble"].Value),
                    Convert.ToInt32(dgvInmuebles.CurrentRow.Cells["ColSuperficie"].Value),
                    Convert.ToInt32(dgvInmuebles.CurrentRow.Cells["ColAñoConstruccion"].Value),
                    Convert.ToString(dgvInmuebles.CurrentRow.Cells["ColDescripcion"].Value),
                    new TipoInmueble(),
                    new Barrio(),
                    Convert.ToString(dgvInmuebles.CurrentRow.Cells["ColDireccion"].Value),
                    Convert.ToInt32(dgvInmuebles.CurrentRow.Cells["ColNroDireccion"].Value),
                    Convert.ToDouble(dgvInmuebles.CurrentRow.Cells["ColPrecio"].Value)
                );

                FrmCreateUpdateInmueble frmCreateUpdate = new FrmCreateUpdateInmueble(false, oInmueble);
                frmCreateUpdate.Owner = this;
                frmCreateUpdate.ShowDialog();
            }
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

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de que desea eliminar el inmueble?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int codInmueble = Convert.ToInt32(dgvInmuebles.CurrentRow.Cells["CodInmueble"].Value);
                    string url = $"https://localhost:7027/api/Inmueble/eliminar-inmueble/{codInmueble}";

                    string response = await ClienteSingleton.GetInstance().DeleteAsync(url);

                    if (!string.IsNullOrEmpty(response))
                    {
                        MessageBox.Show("El inmueble se eliminó con éxito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async void FrmSoporteInmueble_Load(object sender, EventArgs e)
        {
            await CargarDataGridView();
        }
    }
}
