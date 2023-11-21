using InmobiliariaBack.Datos;
using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Dominio;
using InmobiliariaBack.Dominio.Persona;
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

namespace InmobiliariaFront.Soporte.Clientes
{
    public partial class FrmCreateUpdateCliente : Form
    {
        bool esCreate;
        Cliente oCliente;

        public FrmCreateUpdateCliente(bool esCreate, Cliente oCliente)
        {
            InitializeComponent();
            this.esCreate = esCreate;
            this.oCliente = oCliente;
        }

        private async Task<int> ObtenerProximoCliente()
        {
            try
            {
                string url = "https://localhost:7027/api/Cliente/cliente";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    int proximoCliente = JsonConvert.DeserializeObject<int>(response);
                    return proximoCliente;
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

        private async void FrmCreateUpdateCliente_Load(object sender, EventArgs e)
        {
            lblCliente.Text = lblCliente.Text + " " + await ObtenerProximoCliente();
            await CargarComboBarrios();

            if (!esCreate)
            {
                txtNombre.Text = oCliente.Nombre;
                txtApellido.Text = oCliente.Apellido;
                dtpNacimiento.Value = oCliente.FechaNacimiento;
                txtDocumento.Text = oCliente.Documento.ToString();
                txtCuil.Text = oCliente.Cuil;
                dtpRegistro.Value = oCliente.FechaRegistro;
                txtDireccion.Text = oCliente.Direccion;
                txtNroDireccion.Text = oCliente.NroDireccion.ToString();
            }
        }

        private bool EsMayorDeEdad(DateTime fechaNacimiento)
        {
            DateTime ahora = DateTime.Now;

            // Calcular la edad en años
            int edad = ahora.Year - fechaNacimiento.Year;

            // Restar un año si aún no ha cumplido años en este año
            if (fechaNacimiento > ahora.AddYears(-edad))
            {
                edad--;
            }

            // Verificar si la edad es mayor o igual a 18
            return edad >= 18;
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar un apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!EsMayorDeEdad(dtpNacimiento.Value))
            {
                MessageBox.Show("La persona debe ser mayor de 18 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                MessageBox.Show("Debe ingresar un documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtCuil.Text))
            {
                MessageBox.Show("Debe ingresar un CUIL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un barrio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe ingresar una dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtNroDireccion.Text))
            {
                MessageBox.Show("Debe ingresar un N° de dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    Barrio oBarrio = (Barrio)cboBarrio.SelectedItem;
                    int proximoCliente = await ObtenerProximoCliente();

                    List<Parametro> listaParametros = new List<Parametro>
                    {
                        new Parametro("@cod_cliente", esCreate ? proximoCliente : oCliente.CodCliente),
                        new Parametro("@nombre", Convert.ToString(txtNombre.Text)),
                        new Parametro("@apellido", Convert.ToString(txtApellido.Text)),
                        new Parametro("@fecha_nacimiento", Convert.ToDateTime(dtpNacimiento.Value)),
                        new Parametro("@documento", Convert.ToString(txtDocumento.Text)),
                        new Parametro("@cuil", Convert.ToString(txtCuil.Text)),
                        new Parametro("@fecha_registro", Convert.ToDateTime(dtpRegistro.Value)),
                        new Parametro("@cod_barrio", Convert.ToInt32(oBarrio.CodBarrio)),
                        new Parametro("@direccion", Convert.ToString(txtDireccion.Text)),
                        new Parametro("@nro_direccion", Convert.ToString(txtNroDireccion.Text)),
                    };

                    string data = JsonConvert.SerializeObject(listaParametros);
                    string url = esCreate
                        ? "https://localhost:7027/api/Cliente/insertar-cliente"
                        : "https://localhost:7027/api/Cliente/modificar-cliente";

                    string response = "";

                    if (esCreate)
                    {
                        response = await ClienteSingleton.GetInstance().PostAsync(url, data);
                    }
                    else
                    {
                        response = await ClienteSingleton.GetInstance().PutAsync(url, data);
                    }



                    if (!string.IsNullOrEmpty(response))
                    {
                        MessageBox.Show($"El cliente se {(esCreate ? "insertó" : "actualizó")} con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            string texto = txtDocumento.Text;

            // Verificar si el texto contiene caracteres no numéricos
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                {
                    // Si encuentra un carácter no numérico, elimínalo del texto
                    txtDocumento.Text = txtDocumento.Text.Remove(txtDocumento.Text.Length - 1);
                    txtDocumento.SelectionStart = txtDocumento.Text.Length; // Ubica el cursor al final del texto
                    return;
                }
            }
        }

        private void txtNroDireccion_TextChanged(object sender, EventArgs e)
        {
            string texto = txtNroDireccion.Text;

            // Verificar si el texto contiene caracteres no numéricos
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                {
                    // Si encuentra un carácter no numérico, elimínalo del texto
                    txtNroDireccion.Text = txtNroDireccion.Text.Remove(txtNroDireccion.Text.Length - 1);
                    txtNroDireccion.SelectionStart = txtNroDireccion.Text.Length; // Ubica el cursor al final del texto
                    return;
                }
            }
        }

        private void FrmCreateUpdateCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmSoporteClientes)Owner).ActualizarDataGridView();
        }
    }
}
