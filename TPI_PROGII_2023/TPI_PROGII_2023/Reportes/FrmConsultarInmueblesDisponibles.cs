using InmobiliariaBack.Datos;
using InmobiliariaBack.DTO;
using InmobiliariaFront.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmobiliariaFront.Reportes
{
    public partial class FrmConsultarInmueblesDisponibles : Form
    {
        public FrmConsultarInmueblesDisponibles()
        {
            InitializeComponent();
        }

        private void FrmConsultarInmueblesDisponibles_Load(object sender, EventArgs e)
        {
            numPrecioDesde.Value = 50000;
            numPrecioHasta.Value = 900000;
        }

        private async Task Consultar()
        {
            try
            {
                List<Parametro> listaParametros = new List<Parametro>
                {
                    new Parametro("@LOCALIDAD", txtLocalidad.Text),
                    new Parametro("@BARRIO", txtBarrio.Text),
                    new Parametro("@PRECIO1", Convert.ToString(numPrecioDesde.Value)),
                    new Parametro("@PRECIO2", Convert.ToString(numPrecioHasta.Value))
                };

                string data = JsonConvert.SerializeObject(listaParametros);
                string url = "https://localhost:7027/api/Inmueble/inmuebles-disponibles";

                string response = await ClienteSingleton.GetInstance().PostAsync(url, data);

                if (!string.IsNullOrEmpty(response))
                {
                    List<InmuebleDisponibleDTO> listaInmuebles = JsonConvert.DeserializeObject<List<InmuebleDisponibleDTO>>(response);

                    dgvInmueblesDisponibles.Rows.Clear();

                    foreach (InmuebleDisponibleDTO oInmuebleDisponible in listaInmuebles)
                    {
                        dgvInmueblesDisponibles.Rows.Add(new object[] {
                            oInmuebleDisponible.Localidad,
                            oInmuebleDisponible.Barrio,
                            oInmuebleDisponible.DescInmueble,
                            oInmuebleDisponible.DirecInmueble + " " + oInmuebleDisponible.NroDireccion,
                            oInmuebleDisponible.Precio.ToString("C", new CultureInfo("es-AR")),
                            oInmuebleDisponible.Transaccion
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

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            await Consultar();
        }

        private async void txtBarrio_TextChanged(object sender, EventArgs e)
        {
            await Consultar();
        }

        private async void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            await Consultar();
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
