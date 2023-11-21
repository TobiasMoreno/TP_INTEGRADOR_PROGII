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
using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InmobiliariaFront.Reportes
{
    public partial class FrmConsultarClientesDeudores : Form
    {
        public FrmConsultarClientesDeudores()
        {
            InitializeComponent();
        }

        public async Task Consultar()
        {
            try
            {
                List<Parametro> listaParametros = new List<Parametro>
                {
                    new Parametro("@cant_cuotas", Convert.ToString(numCantImpagas.Value))
                };

                string data = JsonConvert.SerializeObject(listaParametros);
                string url = "https://localhost:7027/api/Cliente/inquilinos-deudores";

                string response = await ClienteSingleton.GetInstance().PostAsync(url, data);

                if (!string.IsNullOrEmpty(response))
                {
                    List<ClienteDeudorDTO> listaClientes = JsonConvert.DeserializeObject<List<ClienteDeudorDTO>>(response);

                    dgvInquilinosDeudores.Rows.Clear();

                    foreach (ClienteDeudorDTO oClienteDeudor in listaClientes)
                    {
                        dgvInquilinosDeudores.Rows.Add(new object[] {
                            oClienteDeudor.NombreCompleto,
                            oClienteDeudor.NroAlquiler,
                            oClienteDeudor.Inmueble,
                            oClienteDeudor.FechaInicio,
                            oClienteDeudor.MesesAlquiler,
                            oClienteDeudor.CantidadFacturasPagas,
                            oClienteDeudor.CantidadFacturasImpagas == 0 ? "Falta pagar mes actual" : oClienteDeudor.CantidadFacturasImpagas
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

        private void FrmConsultarClientesDeudores_Load(object sender, EventArgs e)
        {

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
