using InmobiliariaBack.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariaBack.Dominio.Alquileres;
using InmobiliariaBack.Dominio.Facturas;
using System.Diagnostics;

namespace InmobiliariaBack.Datos.DAO
{
    public class DaoFactura : IDaoFactura
    {
        public int ObtenerProximaFactura()
        {
            SqlParameter proximaFactura = DBHelper.ObtenerInstancia().Consultar("SP_ObtenerProximoCodigoFactura", "@ProximoCodigo", SqlDbType.Int);
            return (int)proximaFactura.Value;
        }

        public int ObtenerProximoDetalleAlquiler()
        {
            SqlParameter proximoAlquiler = DBHelper.ObtenerInstancia().Consultar("SP_ObtenerProximoCodFacturaAlquiler", "@ProximoCodAlq", SqlDbType.Int);
            return (int)proximoAlquiler.Value;
        }

        public int ObtenerProximoDetalleVenta()
        {
            SqlParameter proximaVenta = DBHelper.ObtenerInstancia().Consultar("SP_ObtenerProximoNroDetalleFactura", "@ProximoDetalle", SqlDbType.Int);
            return (int)proximaVenta.Value;
        }

        public int InsertarFactura(Factura factura)
        {
            int aux = 1;

            SqlConnection conexion = DBHelper.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;

            int tipoTransaccion = factura.DetallesFactura.Count() > 0 ? 1 : 0;
            try
            {
                conexion.Open();

                t = conexion.BeginTransaction();

                SqlCommand cmd = new SqlCommand("SP_INSERTAR_FACTURA", conexion, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro_factura", factura.NroFactura);
                cmd.Parameters.AddWithValue("@cod_agente_inmobiliario", factura.AgenteInmobiliario.CodAgenteInmobiliario);
                cmd.Parameters.AddWithValue("@cod_cliente", factura.Cliente.CodCliente);
                cmd.Parameters.AddWithValue("@comision_cliente", factura.ComisionCliente);
                cmd.ExecuteNonQuery();

                if (tipoTransaccion == 1)
                {
                    SqlCommand cmd2;
                    foreach (DetalleFactura det in factura.DetallesFactura)
                    {
                        cmd2 = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@nro_detalle_factura", det.NroDetalleFactura);
                        cmd2.Parameters.AddWithValue("@nro_factura", factura.NroFactura);
                        cmd2.Parameters.AddWithValue("@cod_inmueble", det.Inmueble.CodInmueble);
                        cmd2.Parameters.AddWithValue("@precio", det.Precio);

                        cmd2.ExecuteNonQuery();
                    }
                }
                else
                {
                    SqlCommand cmd3;
                    foreach (DetalleAlquiler det in factura.DetallesAlquiler)
                    {
                        cmd3 = new SqlCommand("SP_INSERTAR_DETALLE_ALQUILER", conexion, t);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.AddWithValue("@cod_factura_alquiler", det.Alquiler.NroAlquiler);
                        cmd3.Parameters.AddWithValue("@nro_factura", factura.NroFactura);
                        cmd3.Parameters.AddWithValue("@cod_alquiler", det.Alquiler.NroAlquiler);
                        cmd3.Parameters.AddWithValue("@nro_cuota", det.NroCuota);
                        cmd3.Parameters.AddWithValue("@precio", det.Precio);

                        cmd3.ExecuteNonQuery();
                    }
                }

                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    //Debug.WriteLine(ex.Message);
                    t.Rollback();
                }
                aux = 0;
            }
            finally
            {
                if (conexion != null || conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return aux;
        }
    }
}
