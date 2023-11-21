using InmobiliariaBack.Datos.Interfaz;
using InmobiliariaBack.Dominio;
using InmobiliariaBack.Dominio.Alquileres;
using InmobiliariaBack.Dominio.Contactos;
using InmobiliariaBack.Dominio.Persona;
using InmobiliariaBack.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Datos.DAO
{
    public class DaoCliente : IDaoCliente
    {
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_CLIENTES");

            foreach (DataRow row in dataTable.Rows)
            {
                Cliente oCliente = new Cliente(
                    Convert.ToInt32(row["cod_cliente"]),
                    Convert.ToInt32(row["documento"]),
                    Convert.ToString(row["nombre"]),
                    Convert.ToString(row["apellido"]),
                    Convert.ToString(row["cuil"]),          
                    new Barrio(Convert.ToInt32(row["cod_barrio"]), "", new Localidad()),
                    Convert.ToString(row["direccion"]),
                    Convert.ToInt32(row["nro_direccion"]),
                    Convert.ToDateTime(row["fecha_registro"]),
                    Convert.ToDateTime(row["fecha_nacimiento"]),
                    new List<Contacto>(),
                    new List<Alquiler>()
                );

                listaClientes.Add(oCliente);
            }

            return listaClientes;
        }

        public List<ClienteCumplidorDTO> ObtenerClientesCumplidores(List<Parametro> listaParametros)
        {
            List<ClienteCumplidorDTO> listaClientesCumplidores = new List<ClienteCumplidorDTO>();

            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_CLIENTES_CUMPLIDORES", listaParametros);

            foreach (DataRow row in dataTable.Rows)
            {
                ClienteCumplidorDTO oClienteCumplidor = new ClienteCumplidorDTO();

                oClienteCumplidor.NombleCliente = Convert.ToString(row["Cliente"]);
                oClienteCumplidor.Inmueble = Convert.ToString(row["Inmueble"]);
                oClienteCumplidor.Barrio = Convert.ToString(row["Barrio"]);
                oClienteCumplidor.Direccion = Convert.ToString(row["Direccion"]);
                oClienteCumplidor.Altura = Convert.ToInt32(row["Altura"]);

                listaClientesCumplidores.Add(oClienteCumplidor);
            }

            return listaClientesCumplidores;
        }

        public List<ClienteDeudorDTO> ObtenerClientesDeudores(List<Parametro> listaParametros)
        {
            List<ClienteDeudorDTO> listaClientesDeudores = new List<ClienteDeudorDTO>();

            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_INQUILINOS_DEUDORES", listaParametros);

            foreach (DataRow row in dataTable.Rows)
            {
                ClienteDeudorDTO oClienteDeudor = new ClienteDeudorDTO();

                oClienteDeudor.NombreCompleto = Convert.ToString(row["Cliente"]);
                oClienteDeudor.NroAlquiler = Convert.ToInt32(row["Nro. Alquiler"]);
                oClienteDeudor.Inmueble = Convert.ToString(row["Inmueble"]);
                oClienteDeudor.FechaInicio = Convert.ToDateTime(row["Fecha Inicio"]);
                oClienteDeudor.MesesAlquiler = Convert.ToInt32(row["Meses de alquiler a la fecha"]);
                oClienteDeudor.CantidadFacturasPagas = Convert.ToInt32(row["Cantidad de facturas pagas"]);
                oClienteDeudor.CantidadFacturasImpagas = Convert.ToInt32(row["Debe"]);

                listaClientesDeudores.Add(oClienteDeudor);
            }

            return listaClientesDeudores;
        }

        public int ObtenerProximoCliente()
        {
            SqlParameter proximoCliente = DBHelper.ObtenerInstancia().Consultar("SP_ObtenerProximoCodCliente", "@ProximoCliente", SqlDbType.Int);
            return (int)proximoCliente.Value;
        }

        public int InsertarClientes(List<Parametro> listaParametros)
        {
            int resultado = DBHelper.ObtenerInstancia().Actualizar("SP_INSERTAR_CLIENTE", listaParametros);
            return resultado;
        }

        public int ModificarClientes(List<Parametro> listaParametros)
        {
            int resultado = DBHelper.ObtenerInstancia().Actualizar("SP_MODIFICAR_CLIENTE", listaParametros);
            return resultado;
        }
        public int EliminarClientes(List<Parametro> listaParametros)
        {
            int resultado = DBHelper.ObtenerInstancia().Actualizar("SP_ELIMINAR_CLIENTE", listaParametros);
            return resultado;
        }
    }
}
