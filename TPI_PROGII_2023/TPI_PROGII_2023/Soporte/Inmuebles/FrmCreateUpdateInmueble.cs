﻿using InmobiliariaBack.Datos;
using InmobiliariaBack.Dominio;
using InmobiliariaBack.Dominio.Inmuebles;
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

namespace InmobiliariaFront.Soporte.Inmuebles
{
    public partial class FrmCreateUpdateInmueble : Form
    {
        bool esCreate;
        Inmueble oInmueble;
        public FrmCreateUpdateInmueble(bool esCreate, Inmueble oInmueble)
        {
            InitializeComponent();
            this.esCreate = esCreate;
            this.oInmueble = oInmueble;
        }
        private async Task<int> ObtenerProximoInmueble()
        {
            try
            {
                string url = "https://localhost:7027/api/Inmueble/inmueble";

                string response = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(response))
                {
                    int proximoInmueble = JsonConvert.DeserializeObject<int>(response);
                    return proximoInmueble;
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
        public bool Validar()
        {
            if (NumSuperficie.Value < 100)
            {
                MessageBox.Show("Debe ingresar una superficie válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (NumAño.Value < 1910)
            {
                MessageBox.Show("Debe ingresar un año válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un barrio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboTipoInmueble.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de inmueble", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (numPrecio.Value == 0)
            {
                MessageBox.Show("Debe ingresar un precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void FrmCreateUpdateInmueble_Load(object sender, EventArgs e)
        {
            await ObtenerProximoInmueble();
            await CargarComboBarrios();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    Barrio oBarrio = (Barrio)cboBarrio.SelectedItem;
                    TipoInmueble oTipo = (TipoInmueble)cboTipoInmueble.SelectedItem;
                    int proximoInmueble = await ObtenerProximoInmueble();

                    List<Parametro> listaParametros = new List<Parametro>
                    {
                        new Parametro("@cod_inmueble", esCreate ? proximoInmueble : oInmueble.CodInmueble),
                        new Parametro("@superficie", Convert.ToInt32(NumSuperficie.Value)),
                        new Parametro("@año_construccion", Convert.ToInt32(NumAño.Value)),
                        new Parametro("@descripcion", Convert.ToString(txtDescripcion.Text)),
                        new Parametro("@cod_tipo_inmueble", Convert.ToInt32(oTipo.CodTipoInmueble)),
                        new Parametro("@cod_barrio",  Convert.ToInt32(oBarrio.CodBarrio)),
                        new Parametro("@direccion", Convert.ToString(txtDireccion.Text)),
                        new Parametro("@nro_direccion",Convert.ToString(txtNroDireccion.Text)),
                        new Parametro("@precio", Convert.ToString(numPrecio.Value)),
                    };

                    string data = JsonConvert.SerializeObject(listaParametros);
                    string url = esCreate
                        ? "https://localhost:7027/api/Inmueble/insertar-inmueble"
                        : "https://localhost:7027/api/Inmueble/modificar-inmueble";

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
                        MessageBox.Show($"El inmueble se {(esCreate ? "insertó" : "actualizó")} con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
