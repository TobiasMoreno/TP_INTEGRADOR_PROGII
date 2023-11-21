using InmobiliariaBack.Dominio.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Datos.Interfaz
{
    public interface IDaoFactura
    {
        int ObtenerProximaFactura();
        int ObtenerProximoDetalleVenta();
        int ObtenerProximoDetalleAlquiler();
        int InsertarFactura(Factura oFactura);
    }
}
