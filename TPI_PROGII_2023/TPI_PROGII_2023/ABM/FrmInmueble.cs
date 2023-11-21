using InmobiliariaBack.Dominio;
using InmobiliariaBack.Dominio.Inmuebles;
using InmobiliariaFront.Clientes;
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

namespace InmobiliariaFront.ABM
{
    public partial class FrmInmueble : Form
    {
        public FrmInmueble()
        {
            InitializeComponent();
        }
        private async void FrmInmueble_Load(object sender, EventArgs e)
        {
            await CargarCboTipoInmueble();
            await CargarComboBarrios();
        }
        private async Task CargarCboTipoInmueble()
        {
            try
            {
                string url = "https://localhost:7027/api/TipoInmueble/Tipo-de-Inmuebles";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    List<TipoInmueble> listaTipoInmuebles = JsonConvert.DeserializeObject<List<TipoInmueble>>(response);

                    cboTipoInmueble.DataSource = listaTipoInmuebles;
                    cboTipoInmueble.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboTipoInmueble.ValueMember = "CodTipoInmueble";
                    cboTipoInmueble.DisplayMember = "ValorTipoInmueble";
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
        private async Task CargarComboBarrios()
        {
            try
            {
                string url = "https://localhost:7027/api/Barrio/barrios";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    List<Barrio> listaBarrios = JsonConvert.DeserializeObject<List<Barrio>>(response);

                    cboBarrio.DataSource = listaBarrios;
                    cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboBarrio.ValueMember = "CodBarrio";
                    cboBarrio.DisplayMember = "NombreBarrio";
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
        public bool Validar()
        {
            if (NumSuperficie.Value == 0)
            {
                MessageBox.Show("Debe ingresar una superficie mayor a 200 metros");
                return false;
            }
            if (NumAñoConstruccion.Value == 0)
            {
                MessageBox.Show("Debe ingresar un año de construccion");
                return false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción del inmueble");
                return false;
            }
            if (cboTipoInmueble.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de inmueble");
                return false;
            }
            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un barrio");
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe ingresar una dirección");
                return false;
            }
            if (string.IsNullOrEmpty(txtNroDireccion.Text))
            {
                MessageBox.Show("Debe ingresar la altura del domicilio");
                return false;
            }
            if (NumContrato.Value == 0)
            {
                MessageBox.Show("Debe deleccionar el Contrato correspondiente");
                return false;
            }
            if (NumPrecio.Value == 0)
            {
                MessageBox.Show("Debe ingresar un precio");
                return false;
            }
            return true;
        }
        public void LimpiarCampos()
        {
            NumSuperficie.Value = 0;
            NumAñoConstruccion.Value = 1990;
            txtDescripcion.Text = string.Empty;
            cboTipoInmueble.SelectedIndex = -1;
            cboBarrio.SelectedIndex = -1;
            txtDireccion.Text = string.Empty;
            txtNroDireccion.Text = string.Empty;
            NumContrato.Value = 0;
            NumPrecio.Value = 0;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                dgvInmuebles.Rows.Clear();
                dgvInmuebles.Rows.Add
                    ("",NumSuperficie.Value,NumAñoConstruccion.Value, txtDescripcion.Text,
                    cboTipoInmueble.SelectedItem, cboBarrio.SelectedItem, txtDireccion.Text,
                    txtNroDireccion.Text,NumContrato.Value,NumPrecio.Value
                    );
                LimpiarCampos();
            }

        }
    }
}
