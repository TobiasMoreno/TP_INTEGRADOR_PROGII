using InmobiliariaBack.Datos.Interfaz;
using InmobiliariaBack.Dominio.Alquileres;
using InmobiliariaBack.Dominio.Contactos;
using InmobiliariaBack.Dominio;
using InmobiliariaBack.Dominio.Inmuebles;
using InmobiliariaBack.Dominio.Persona;
using InmobiliariaBack.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Datos.DAO
{
    public class DaoInmueble : IDaoInmueble
    {
        public List<CantInmuPropDTO> ObtenerCantInmueblesPorPropietario(List<Parametro> listaParametros)
        {
            List<CantInmuPropDTO> listaCantInmuProp = new List<CantInmuPropDTO>();

            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_CANT_INMUEBLE_PROP", listaParametros);

            foreach (DataRow row in dataTable.Rows)
            {
                CantInmuPropDTO oInmuXProp = new CantInmuPropDTO();

                oInmuXProp.NombreCompleto = Convert.ToString(row["Propietario"]);
                oInmuXProp.CantInmueble = Convert.ToInt32(row["Cantidad de Propiedades"]);

                listaCantInmuProp.Add(oInmuXProp);
            }

            return listaCantInmuProp;
        }

        public List<Inmueble> ObtenerInmuebles()
        {
            List<Inmueble> listaInmuebles = new List<Inmueble>();
            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_INMUEBLES");

            foreach (DataRow dr in dataTable.Rows)
            {
                Inmueble oInmueble = new Inmueble
                (
                    Convert.ToInt32(dr["cod_inmueble"]),
                    Convert.ToDouble(dr["superficie"]),
                    Convert.ToInt32(dr["año_construccion"]),
                    Convert.ToString(dr["descripcion"]),
                    new TipoInmueble(),
                    new Barrio(Convert.ToInt32(dr["cod_barrio"]), "", new Localidad()),
                    Convert.ToString(dr["direccion"]),
                    Convert.ToInt32(dr["nro_direccion"]),
                    Convert.ToDouble(dr["precio"])
                );

                listaInmuebles.Add(oInmueble);
            }
            return listaInmuebles;
        }

        public List<InmuebleCaptadoDTO> ObtenerInmueblesCaptados(List<Parametro> listaParametros)
        {
            List<InmuebleCaptadoDTO> listaInmueblesCaptados = new List<InmuebleCaptadoDTO>();

            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_PROPIEDADES_CAPTADAS", listaParametros);

            foreach (DataRow row in dataTable.Rows)
            {
                InmuebleCaptadoDTO oInmuebleCaptado = new InmuebleCaptadoDTO();

                oInmuebleCaptado.Descripcion = Convert.ToString(row["Inmueble"]);
                oInmuebleCaptado.NombreCompletoAgente= Convert.ToString(row["Agente Inmobiliario"]); ;
                oInmuebleCaptado.NombreCompletoCliente = Convert.ToString(row["Cliente"]); ;
                oInmuebleCaptado.Año= Convert.ToInt32(row["Año"]); ;
                oInmuebleCaptado.NroFactura = Convert.ToString(row["Nro. Factura"]); ;
                oInmuebleCaptado.CostoVenta = Convert.ToString(row["Costo de venta"]); ;
                oInmuebleCaptado.ComisionPorContrato = Convert.ToString(row["Comision por contrato"]); ;
                oInmuebleCaptado.ComisionPorCliente = Convert.ToString(row["Comision por parte del cliente"]); ;
                oInmuebleCaptado.TotalGanancias = Convert.ToString(row["Total de Ganancia"]);

                listaInmueblesCaptados.Add(oInmuebleCaptado);
            }

            return listaInmueblesCaptados;
        }

        public List<InmuebleContratoDTO> ObtenerInmueblesContratos(List<Parametro> listaParametros)
        {
            List<InmuebleContratoDTO> lstInmueblesContratos = new List<InmuebleContratoDTO>();
            Console.WriteLine(listaParametros[0].Valor + " " + listaParametros[1].Valor);
            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONTRATOS_POR_FINALIZAR", listaParametros);
            
            foreach (DataRow row in dt.Rows)
            {
                InmuebleContratoDTO oInmuebleContrato = new InmuebleContratoDTO();

                oInmuebleContrato.NombrePropietario = Convert.ToString(row["Propietario"]);
                oInmuebleContrato.DescripcionInmueble = Convert.ToString(row["Inmueble"]);
                oInmuebleContrato.Barrio = Convert.ToString(row["Barrio"]);
                oInmuebleContrato.Direccion = Convert.ToString(row["Direccion"]);
                oInmuebleContrato.Altura = Convert.ToInt32(row["Altura"]);
                oInmuebleContrato.FechaFinalizacion = Convert.ToDateTime(row["Fecha de Finalización"]);
                oInmuebleContrato.Transaccion = Convert.ToString(row["Transacción"]);

                lstInmueblesContratos.Add(oInmuebleContrato);
            }

            return lstInmueblesContratos;
        }

        public List<InmuebleDisponibleDTO> ObtenerInmueblesDisponibles(List<Parametro> listaParametros)
        {
            List<InmuebleDisponibleDTO> listaInmueblesDisponibles = new List<InmuebleDisponibleDTO>();

            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_INMUEBLES_DISPONIBLES", listaParametros);

            foreach (DataRow row in dataTable.Rows)
            {
                InmuebleDisponibleDTO oInmuebleDisponible = new InmuebleDisponibleDTO();

                oInmuebleDisponible.Localidad = Convert.ToString(row["Localidad"]);
                oInmuebleDisponible.Barrio = Convert.ToString(row["Barrio"]);
                oInmuebleDisponible.DescInmueble = Convert.ToString(row["Inmueble"]);
                oInmuebleDisponible.DirecInmueble = Convert.ToString(row["Direccion"]);
                oInmuebleDisponible.NroDireccion = Convert.ToInt32(row["Altura"]);
                oInmuebleDisponible.Precio = Convert.ToInt32(row["Precio"]);
                oInmuebleDisponible.Transaccion = Convert.ToString(row["Transaccion"]);

                listaInmueblesDisponibles.Add(oInmuebleDisponible);
            }

            return listaInmueblesDisponibles;
        }
        public int InsertarInmueble(List<Parametro> listaParametros)
        {
            int resultado = DBHelper.ObtenerInstancia().Actualizar("SP_INSERTAR_INMUEBLE", listaParametros);
            return resultado;
        }
        public int ModificarInmueble(List<Parametro> listaParametros)
        {
            int resultado = DBHelper.ObtenerInstancia().Actualizar("SP_MODIFICAR_INMUEBLE", listaParametros);
            return resultado;
        }
        public int EliminarInmueble(List<Parametro> listaParametros)
        {
            int resultado = DBHelper.ObtenerInstancia().Actualizar("SP_ELIMINAR_INMUEBLE", listaParametros);
            return resultado;
        }
    }
}
