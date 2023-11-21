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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmobiliariaFront.Reportes
{
    public partial class FrmConsultarContratosPorFinalizar : Form
    {
        public FrmConsultarContratosPorFinalizar()
        {
            InitializeComponent();
        }

        private async Task Consultar()
        {
            try
            {
                List<Parametro> listaParametros = new List<Parametro>
                {
                    new Parametro("@cantMeses", Convert.ToInt32(numMesesVencimiento.Value)),
                    new Parametro("@tipoContrato", cboTipoContrato.SelectedValue)
                };

                string data = JsonConvert.SerializeObject(listaParametros);
                string url = "https://localhost:7027/api/Inmueble/inmuebles-contratos";

                string response = await ClienteSingleton.GetInstance().PostAsync(url, data);

                if (!string.IsNullOrEmpty(response))
                {
                    List<InmuebleContratoDTO> listaContratos = JsonConvert.DeserializeObject<List<InmuebleContratoDTO>>(response);

                    dgvContratosPorFinalizar.Rows.Clear();

                    foreach (InmuebleContratoDTO oContrato in listaContratos)
                    {
                        dgvContratosPorFinalizar.Rows.Add(new object[] {
                            oContrato.NombrePropietario,
                            oContrato.DescripcionInmueble,
                            oContrato.Barrio,
                            oContrato.Direccion + " " + oContrato.Altura,
                            oContrato.FechaFinalizacion,
                            oContrato.Transaccion
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

        public void CargarCombo()
        {
            var items = new[]
            {
                new { Value = 1, Display = "Alquiler" },
                new { Value = 2, Display = "Venta" },
                new { Value = 0, Display = "Ambos" }
            };

            cboTipoContrato.DataSource = items;
            cboTipoContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoContrato.ValueMember = "Value";
            cboTipoContrato.DisplayMember = "Display";
        }

        private void FrmConsultarContratosPorFinalizar_Load(object sender, EventArgs e)
        {
            CargarCombo();
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
