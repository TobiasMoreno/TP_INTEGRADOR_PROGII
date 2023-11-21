using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio.Alquileres
{
    public class DetalleAlquiler
    {
        // Atributos
        public int NroAlquiler { get; set; }
        public Alquiler Alquiler { get; set; }
        public int NroCuota { get; set; }
        public float Precio { get; set; }

        // Constructor 
        public DetalleAlquiler(int nroAlquiler, Alquiler alquiler, int nroCuota, float precio)
        {
            NroAlquiler = nroAlquiler; Alquiler = alquiler; NroCuota = nroCuota; Precio = precio;
        }

        public DetalleAlquiler()
        {
            
        }
    }
}
