using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Datos.Interfaz;
using InmobiliariaBack.Dominio.Facturas;
using InmobiliariaBack.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Servicios
{
    public class GestorFactura : IGestorFactura
    {
        private IDaoFactura daoFactura;

        public GestorFactura()
        {
            daoFactura = new DaoFactura();
        }

        public int InsertarFactura(Factura oFactura)
        {
            return daoFactura.InsertarFactura(oFactura);
        }

        public int ObtenerProximaFactura()
        {
            return daoFactura.ObtenerProximaFactura();
        }

        public int ObtenerProximoDetalleAlquiler()
        {
            return daoFactura.ObtenerProximoDetalleAlquiler();
        }

        public int ObtenerProximoDetalleVenta()
        {
            return daoFactura.ObtenerProximoDetalleVenta();
        }
    }
}
