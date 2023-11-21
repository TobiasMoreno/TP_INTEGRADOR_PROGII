using InmobiliariaBack.Datos;
using InmobiliariaBack.DTO;
using InmobiliariaFront.Client;
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

namespace InmobiliariaFront.Reportes
{
    public partial class FrmConsultarInmueblesCaptados : Form
    {
        public FrmConsultarInmueblesCaptados()
        {
            InitializeComponent();
        }

        private void FrmConsultarInmueblesCaptados_Load(object sender, EventArgs e)
        {

        }

        private async Task Consultar()
        {
            try
            {
                List<Parametro> listaParametros = new List<Parametro>
                {
                    new Parametro("@año_desde", Convert.ToString(numAñoDesde.Value)),
                    new Parametro("@año_hasta", Convert.ToString(numAñoHasta.Value)),
                    new Parametro("@agente_inmobiliario", Convert.ToString(txtAgenteInmobiliario.Text))
                };

                string data = JsonConvert.SerializeObject(listaParametros);
                string url = "https://localhost:7027/api/Inmueble/inmuebles-captados";

                string response = await ClienteSingleton.GetInstance().PostAsync(url, data);

                if (!string.IsNullOrEmpty(response))
                {
                    List<InmuebleCaptadoDTO> listaInmuebles = JsonConvert.DeserializeObject<List<InmuebleCaptadoDTO>>(response);

                    dgvInmueblesCaptados.Rows.Clear();

                    foreach (InmuebleCaptadoDTO oInmuebleCaptado in listaInmuebles)
                    {
                        dgvInmueblesCaptados.Rows.Add(new object[] {
                            oInmuebleCaptado.Descripcion,
                            oInmuebleCaptado.NombreCompletoAgente,
                            oInmuebleCaptado.NombreCompletoCliente,
                            oInmuebleCaptado.Año,
                            oInmuebleCaptado.NroFactura,
                            "$ " + oInmuebleCaptado.CostoVenta,
                            oInmuebleCaptado.ComisionPorContrato,
                            oInmuebleCaptado.ComisionPorCliente,
                            oInmuebleCaptado.TotalGanancias
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

        private async void txtAgenteInmobiliario_TextChanged(object sender, EventArgs e)
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
