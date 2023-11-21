using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariaBack.Dominio.Inmuebles;

namespace InmobiliariaBack.Dominio.Facturas
{
    public class DetalleFactura
    {
        // Atributos
        public int NroDetalleFactura { get; set; }
        public Inmueble Inmueble { get; set; }
        public float Precio { get; set; }

        // Constructor
        public DetalleFactura(int nroDetalleFactura, Inmueble inmueble, float precio)
        {
            NroDetalleFactura = nroDetalleFactura;
            Inmueble = inmueble;
            Precio = precio;
        }
        public DetalleFactura()
        {
            
        }
    }
}
