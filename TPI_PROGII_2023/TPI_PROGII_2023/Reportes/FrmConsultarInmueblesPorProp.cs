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
    public partial class FrmConsultarInmueblesPorProp : Form
    {
        public FrmConsultarInmueblesPorProp()
        {
            InitializeComponent();
        }
        private async Task Consultar()
        {
            try
            {
                List<Parametro> listaParametros = new List<Parametro>
                {
                    new Parametro("@CANT_MIN_PROP", Convert.ToString(numCantidad.Value))
                };

                string data = JsonConvert.SerializeObject(listaParametros);
                string url = "https://localhost:7027/api/Inmueble/inmuebles-por-propietario";

                string response = await ClienteSingleton.GetInstance().PostAsync(url, data);

                if (!string.IsNullOrEmpty(response))
                {
                    List<CantInmuPropDTO> listaInmuebles = JsonConvert.DeserializeObject<List<CantInmuPropDTO>>(response);

                    dgvInmueblesProp.Rows.Clear();

                    foreach (CantInmuPropDTO oInmProp in listaInmuebles)
                    {
                        dgvInmueblesProp.Rows.Add(new object[] {
                            oInmProp.NombreCompleto,
                            oInmProp.CantInmueble + " propiedades",
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

        private async void numCantidad_ValueChanged(object sender, EventArgs e)
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
