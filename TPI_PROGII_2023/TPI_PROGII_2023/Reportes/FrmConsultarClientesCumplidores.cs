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
    public partial class FrmConsultarClientesCumplidores : Form
    {
        public FrmConsultarClientesCumplidores()
        {
            InitializeComponent();
        }

        public async Task Consultar()
        {
            try
            {
                List<Parametro> listaParametros = new List<Parametro>
                {
                    new Parametro("@fechaDesde", dtpDesde.Value),
                    new Parametro("@fechaHasta", dtpHasta.Value),
                    new Parametro("@cantDias", Convert.ToString(numDia.Value))
                };

                string data = JsonConvert.SerializeObject(listaParametros);
                string url = "https://localhost:7027/api/Cliente/inquilinos-cumplidores";

                string response = await ClienteSingleton.GetInstance().PostAsync(url, data);

                if (!string.IsNullOrEmpty(response))
                {
                    List<ClienteCumplidorDTO> listaClientes = JsonConvert.DeserializeObject<List<ClienteCumplidorDTO>>(response);

                    dgvInquilinosCumplidores.Rows.Clear();

                    foreach (ClienteCumplidorDTO oClienteCumplidor in listaClientes)
                    {
                        dgvInquilinosCumplidores.Rows.Add(new object[] {
                            oClienteCumplidor.NombleCliente,
                            oClienteCumplidor.Inmueble,
                            oClienteCumplidor.Barrio,
                            oClienteCumplidor.Direccion + " " + oClienteCumplidor.Altura,
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
    }
}
