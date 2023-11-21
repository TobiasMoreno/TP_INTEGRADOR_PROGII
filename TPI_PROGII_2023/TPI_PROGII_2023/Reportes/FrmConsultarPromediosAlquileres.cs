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
    public partial class FrmConsultarPromediosAlquileres : Form
    {
        public FrmConsultarPromediosAlquileres()
        {
            InitializeComponent();
        }

        private void FrmConsultarPromediosAlquileres_Load(object sender, EventArgs e)
        {
            dgvPromedioAlquileres.Columns["ColPromedioDesde"].HeaderText = "Promedio desde 0";
            dgvPromedioAlquileres.Columns["ColPromedioHasta"].HeaderText = "Promedio hasta 0";
        }

        private async Task Consultar()
        {
            try
            {
                List<Parametro> listaParametros = new List<Parametro>
                {
                    new Parametro("@año_desde", Convert.ToString(numAñoDesde.Value)),
                    new Parametro("@año_hasta", Convert.ToString(numAñoHasta.Value)),
                };

                string data = JsonConvert.SerializeObject(listaParametros);
                string url = "https://localhost:7027/api/Alquiler/promedios-alquileres";

                string response = await ClienteSingleton.GetInstance().PostAsync(url, data);

                if (!string.IsNullOrEmpty(response))
                {
                    List<InflacionAlquilerDTO> listaPromedios = JsonConvert.DeserializeObject<List<InflacionAlquilerDTO>>(response);

                    dgvPromedioAlquileres.Rows.Clear();

                    foreach (InflacionAlquilerDTO oPromedioAlquiler in listaPromedios)
                    {
                        dgvPromedioAlquileres.Rows.Add(new object[] {
                            oPromedioAlquiler.PromedioDesde.ToString("C", new CultureInfo("es-AR")),
                            oPromedioAlquiler.PromedioHasta.ToString("C", new CultureInfo("es-AR")),
                            oPromedioAlquiler.Diferencia.ToString("C", new CultureInfo("es-AR")),
                            oPromedioAlquiler.PorcentajeAumento
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

        private void numAñoDesde_ValueChanged(object sender, EventArgs e)
        {
            dgvPromedioAlquileres.Columns["ColPromedioDesde"].HeaderText = "Promedio desde " + Convert.ToString(numAñoDesde.Value);
        }

        private void numAñoHasta_ValueChanged(object sender, EventArgs e)
        {
            dgvPromedioAlquileres.Columns["ColPromedioHasta"].HeaderText = "Promedio hasta " + Convert.ToString(numAñoHasta.Value);
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
