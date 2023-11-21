using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Dominio;
using InmobiliariaBack.Dominio.Inmuebles;
using InmobiliariaBack.Dominio.Persona;
using InmobiliariaFront.Clientes;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InmobiliariaFront.ABM
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
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
        private bool EsMayorDeEdad(DateTime fechaNacimiento)
        {
            bool aux = false;
            // Calcular la edad
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            // Ajustar la edad si aún no ha llegado el cumpleaños en este año
            if (fechaNacimiento.Date > DateTime.Now.AddYears(-edad))
            {
                aux = true;
            }

            // Verificar si la edad es mayor o igual a 18
            return aux;
        }
        public bool Validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre");
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar un apellido");
                return false;
            }
            if (!EsMayorDeEdad(dtpFechaNacimiento.Value))
            {
                MessageBox.Show("La persona debe ser mayor de 18 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                MessageBox.Show("Debe ingresar un documento");
                return false;
            }
            if (string.IsNullOrEmpty(txtCuil.Text))
            {
                MessageBox.Show("Debe ingresar un CUIL");
                return false;
            }
            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un barrio");
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe ingresar una dirección");
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe ingresar un N° de dirección");
                return false;
            }
            return true;
        }
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            txtDocumento.Clear();
            txtCuil.Clear();
            dtpFechaRegistro.Value = DateTime.Now;
            cboBarrio.SelectedIndex = -1;
            txtDireccion.Clear();
            txtNroDireccion.Clear();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                dgvClientes.Rows.Clear();
                dgvClientes.Rows.Add
                    (txtNombre.Text, txtApellido.Text,
                    dtpFechaNacimiento.Value, txtDocumento.Text,
                    txtCuil.Text, dtpFechaRegistro.Value, cboBarrio.SelectedText,
                    txtDireccion.Text, txtNroDireccion.Text
                    );
                LimpiarCampos();
            }
        }
        private async void FrmCliente_Load(object sender, EventArgs e)
        {
            await CargarComboBarrios();
        }
    }
}
