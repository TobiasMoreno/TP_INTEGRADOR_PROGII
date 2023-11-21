using InmobiliariaBack.Dominio.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Servicios.Interfaz
{
    public interface IGestorFactura
    {
        int ObtenerProximaFactura();
        int ObtenerProximoDetalleVenta();
        int ObtenerProximoDetalleAlquiler();
        int InsertarFactura(Factura oFactura);
    }
}
