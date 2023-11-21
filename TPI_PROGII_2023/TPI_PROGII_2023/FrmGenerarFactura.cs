using InmobiliariaBack.Datos;
using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Dominio;
using InmobiliariaBack.Dominio.Alquileres;
using InmobiliariaBack.Dominio.Facturas;
using InmobiliariaBack.Dominio.Inmuebles;
using InmobiliariaBack.Dominio.Persona;
using InmobiliariaBack.DTO;
using InmobiliariaFront.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_PROGII_2023
{
    public partial class FrmPostPutCliente : Form
    {
        Factura oFactura;

        public FrmPostPutCliente()
        {
            InitializeComponent();
            oFactura = new Factura();
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

            lblFecha.Text = DateTime.Now.ToString();

            lblFactura.Text = lblFactura.Text + " " + await ObtenerProximaFactura();

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

                        numCuota.Enabled = false;
                    }
                    // Alquiler
                    else if ((int)cboTransaccion.SelectedValue == 2)
                    {
                        lblAlquiler.Visible = true;
                        cboAlquiler.Visible = true;
                        lblInmueble.Visible = false;
                        cboInmueble.Visible = false;

                        numCuota.Enabled = true;
                    }
                }
            }
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task<int> ObtenerProximaFactura()
        {
            try
            {
                string url = "https://localhost:7027/api/Factura/proxima-factura";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    int proximaFactura = JsonConvert.DeserializeObject<int>(response);
                    return proximaFactura;
                }
                else
                {
                    MessageBox.Show("La respuesta de la API está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private async Task<int> ObtenerProximoDetalleVenta()
        {
            try
            {
                string url = "https://localhost:7027/api/Factura/proximo-detalle-venta";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    int proximoDetalle = JsonConvert.DeserializeObject<int>(response);
                    return proximoDetalle;
                }
                else
                {
                    MessageBox.Show("La respuesta de la API está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private async Task<int> ObtenerProximoDetalleAlquiler()
        {
            try
            {
                string url = "https://localhost:7027/api/Factura/proximo-detalle-alquiler";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    int proximoDetalle = JsonConvert.DeserializeObject<int>(response);
                    return proximoDetalle;
                }
                else
                {
                    MessageBox.Show("La respuesta de la API está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDetalle())
            {
                if (cboTransaccion.SelectedValue != null)
                {
                    if (int.TryParse(cboTransaccion.SelectedValue.ToString(), out _))
                    {
                        // Venta
                        if ((int)cboTransaccion.SelectedValue == 1)
                        {
                            int proximoDetalle = await ObtenerProximoDetalleVenta();
                            int cantidadDetalles = oFactura.DetallesFactura.Count();

                            int codDetalle = proximoDetalle + cantidadDetalles;

                            DetalleFactura oDetalleVenta = new DetalleFactura(
                                codDetalle,
                                (Inmueble)cboInmueble.SelectedItem,
                                (float)numPrecio.Value
                            );

                            oFactura.AgregarDetalle(true, null, oDetalleVenta);
                            dgvDetalles.Rows.Add(new object[] {
                                (Inmueble)cboInmueble.SelectedItem,
                                "",
                                (float)numPrecio.Value,
                                "Quitar"
                            });
                        }
                        // Alquiler
                        else if ((int)cboTransaccion.SelectedValue == 2)
                        {
                            int proximoDetalle = await ObtenerProximoDetalleAlquiler();
                            int cantidadDetalles = oFactura.DetallesAlquiler.Count();

                            int codDetalle = proximoDetalle + cantidadDetalles;

                            AlquilerDTO oAlquiler = (AlquilerDTO)cboAlquiler.SelectedItem;

                            DetalleAlquiler oDetalleAlquiler = new DetalleAlquiler(
                                codDetalle,
                                new Alquiler(
                                    oAlquiler.CodAlquiler,
                                    new Inmueble(),
                                    new DateTime(),
                                    new DateTime(),
                                    new DateTime(),
                                    0,
                                    true
                                ),
                                (int)numCuota.Value,
                                (float)numPrecio.Value
                            );

                            oFactura.AgregarDetalle(false, oDetalleAlquiler, null);
                            AlquilerDTO oAlquilerDTO = (AlquilerDTO)cboAlquiler.SelectedItem;
                            dgvDetalles.Rows.Add(new object[] {
                                oAlquilerDTO.Resumen,
                                (int)numCuota.Value,
                                (float)numPrecio.Value,
                                "Quitar"
                            });
                        }
                    }
                }
            }
        }

        private bool ValidarDetalle()
        {
            if (cboAlquiler.SelectedIndex == -1 || cboInmueble.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un inmueble/alquiler", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (numPrecio.Value < 0)
            {
                MessageBox.Show("Debe escribir un precio valido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["ColProducto"].Value.ToString().Equals(cboInmueble.Text) || row.Cells["ColProducto"].Value.ToString().Equals(cboAlquiler.Text))
                {
                    MessageBox.Show($"Ese {((int)cboTransaccion.SelectedValue == 1 ? "inmueble" : "alquiler")} ya fue agregado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }

        private void dgvDetalles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvDetalles.Rows.Count > 0)
            {
                cboTransaccion.Enabled = false;
            }
            else
            {
                cboTransaccion.Enabled = true;
            }
        }

        private void dgvDetalles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvDetalles.Rows.Count > 0)
            {
                cboTransaccion.Enabled = false;
            }
            else
            {
                cboTransaccion.Enabled = true;
            }
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 3)
            {
                if (cboTransaccion.SelectedValue != null)
                {
                    if (int.TryParse(cboTransaccion.SelectedValue.ToString(), out _))
                    {
                        // Venta
                        if ((int)cboTransaccion.SelectedValue == 1)
                        {
                            oFactura.QuitarDetalle(true, dgvDetalles.CurrentRow.Index);
                            dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
                        }
                        // Alquiler
                        else if ((int)cboTransaccion.SelectedValue == 2)
                        {
                            oFactura.QuitarDetalle(false, dgvDetalles.CurrentRow.Index);
                            dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
                        }
                    }
                }
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (/*ValidarMaestro()*/ true)
            {
                oFactura.NroFactura = await ObtenerProximaFactura();
                oFactura.FechaFactura = DateTime.Now;
                oFactura.AgenteInmobiliario = (AgenteInmobiliario)cboAgente.SelectedItem;
                oFactura.Cliente = (Cliente)cboCliente.SelectedItem;
                oFactura.ComisionCliente = (float)numComision.Value;

                try
                {
                    /*
                    string data = JsonConvert.SerializeObject(oFactura);
                    string url = "https://localhost:7027/api/Factura/insertar-factura";

                    string response = await ClienteSingleton.GetInstance().PostAsync(url, data);
                    */

                    DaoFactura dao = new DaoFactura();
                    int response = dao.InsertarFactura(oFactura);

                    // Tuvimos que comentar la parte de la API debido a problemas con el serializador
                    if (/*!string.IsNullOrEmpty(response)*/ response != 0)
                    {
                        MessageBox.Show("La factura se insertó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
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
    }
}
