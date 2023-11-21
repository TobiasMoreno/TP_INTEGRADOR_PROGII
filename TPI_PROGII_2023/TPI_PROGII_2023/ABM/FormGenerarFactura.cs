using InmobiliariaBack.Datos;
using InmobiliariaBack.Dominio.Inmuebles;
using InmobiliariaBack.Dominio.Persona;
using InmobiliariaBack.DTO;
using InmobiliariaFront.Clientes;
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

namespace TPI_PROGII_2023
{
    public partial class FormGenerarFactura : Form
    {
        public FormGenerarFactura()
        {
            InitializeComponent();
        }
        public void CargarComboTransaccion()
        {
            var items = new[]
            {
                new { Value = 1, Display = "Venta" },
                new { Value = 2, Display = "Alquiler" }

            };

            cboTransaccion.DataSource = items;
            cboTransaccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTransaccion.ValueMember = "Value";
            cboTransaccion.DisplayMember = "Display";
        }
        private async Task CargarComboClientes()
        {
            try
            {
                string url = "https://localhost:7027/api/Cliente/clientes";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    List<Cliente> listaClientes = JsonConvert.DeserializeObject<List<Cliente>>(response);

                    cboCliente.DataSource = listaClientes;
                    cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboCliente.ValueMember = "CodCliente";
                    cboCliente.DisplayMember = "NombreCompleto";
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
        private async Task CargarComboAgentes()
        {
            try
            {
                string url = "https://localhost:7027/api/Agente/agentes";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    List<AgenteInmobiliario> listaAgentes = JsonConvert.DeserializeObject<List<AgenteInmobiliario>>(response);

                    cboAgente.DataSource = listaAgentes;
                    cboAgente.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboAgente.ValueMember = "CodAgenteInmobiliario";
                    cboAgente.DisplayMember = "NombreCompleto";
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
        private async Task CargarComboInmuebles()
        {
            try
            {
                string url = "https://localhost:7027/api/Inmueble/inmuebles";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    List<Inmueble> listaInmuebles = JsonConvert.DeserializeObject<List<Inmueble>>(response);

                    cboInmueble.DataSource = listaInmuebles;
                    cboInmueble.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboInmueble.ValueMember = "CodInmueble";
                    cboInmueble.DisplayMember = "Descripcion";
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
        private async Task CargarComboAlquileres()
        {
            try
            {
                string url = "https://localhost:7027/api/Alquiler/alquileres";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    List<AlquilerDTO> listaAlquileres = JsonConvert.DeserializeObject<List<AlquilerDTO>>(response);

                    cboAlquiler.DataSource = listaAlquileres;
                    cboAlquiler.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboAlquiler.ValueMember = "CodAlquiler";
                    cboAlquiler.DisplayMember = "Resumen";
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
        private async void FormGenerarFactura_Load(object sender, EventArgs e)
        {
            numComision.Value = 0.05M;
            cboTransaccion.SelectedValue = 1;
            lblAlquiler.Visible = false;
            cboAlquiler.Visible = false;


            CargarComboTransaccion();
            await CargarComboClientes();
            await CargarComboAgentes();
            await CargarComboInmuebles();
            await CargarComboAlquileres();

        }
        private void cboTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTransaccion.SelectedValue != null)
            {
                if (int.TryParse(cboTransaccion.SelectedValue.ToString(), out _))
                {
                    // Venta
                    if ((int)cboTransaccion.SelectedValue == 1)
                    {
                        lblAlquiler.Visible = false;
                        cboAlquiler.Visible = false;
                        lblInmueble.Visible = true;
                        cboInmueble.Visible = true;
                        numComision.Value = 0.03M;
                    }
                    // Alquiler
                    else if ((int)cboTransaccion.SelectedValue == 2)
                    {
                        lblAlquiler.Visible = true;
                        cboAlquiler.Visible = true;
                        lblInmueble.Visible = false;
                        cboInmueble.Visible = false;
                        numComision.Value = 0.03M;
                    }
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //AGREGAR A LA DGV
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR UNA FACTURA DE ALQUILER O DE VENTA
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea abandonar esta pestaña?"
                 , "Volver al inicio"
                 , MessageBoxButtons.YesNo
                 , MessageBoxIcon.Question
                 , MessageBoxDefaultButton.Button2)
                 == DialogResult.Yes)
                Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cboTransaccion.SelectedValue != null)
            {
                if (int.TryParse(cboTransaccion.SelectedValue.ToString(), out _))
                {
                    // Venta
                    if ((int)cboTransaccion.SelectedValue == 1)
                    {
                        
                    }
                    // Alquiler
                    else if ((int)cboTransaccion.SelectedValue == 2)
                    {
                        dgvDetalle.Columns.Add("NroCuota", "N° Cuota");
                    }
                }
            }
        }
        private void ConfigurarColumnasSegunTransaccion()
        {
            dgvDetalle.Columns.Clear();  // Limpiar las columnas existentes

            // Añadir columnas comunes
            dgvDetalle.Columns.Add("ColAgenteInmobiliario", "Agente Inmobiliario");
            dgvDetalle.Columns.Add("ColCliente", "Cliente");
            dgvDetalle.Columns.Add("ColDetalle", "Detalle");
            dgvDetalle.Columns.Add("ColPrecio", "Precio");

            // Obtener el valor de la transacción seleccionada
            if (int.TryParse(cboTransaccion.SelectedValue.ToString(), out int tipoTransaccion))
            {
                // Añadir columnas según el tipo de transacción
                if (tipoTransaccion == 1) // Venta
                {
                    dgvDetalle.Columns.Add("ColumnaVenta1", "Columna Venta 1");
                    dgvDetalle.Columns.Add("ColumnaVenta2", "Columna Venta 2");
                }
                else if (tipoTransaccion == 2) // Alquiler
                {
                    dgvDetalle.Columns.Add("ColumnaAlquiler1", "Columna Alquiler 1");
                    dgvDetalle.Columns.Add("ColumnaAlquiler2", "Columna Alquiler 2");
                }
            }
        }
        private bool existeEnGrilla(string nombre)
        {
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.Cells["colDetalle"].Value.ToString().Equals(nombre))
                {
                    return true;
                }
            }

            return false;

        }
    }
}
