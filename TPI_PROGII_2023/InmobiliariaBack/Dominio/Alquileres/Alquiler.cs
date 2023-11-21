using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariaBack.Dominio.Inmuebles;

namespace InmobiliariaBack.Dominio.Alquileres
{
    public class Alquiler
    {
        // Atributos
        public int NroAlquiler { get; set; }
        public Inmueble Inmueble { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public DateTime FechaFirma { get; set; }
        public float Precio { get; set; }
        public bool EstadoAlquiler { get; set; }

        // Constructor
        public Alquiler(int nroAlquiler, Inmueble inmueble, DateTime fechaInicio, DateTime fechaFinalizacion, DateTime fechaFirma, float precio, bool estadoAlquiler)
        {
            NroAlquiler = nroAlquiler;
            Inmueble = inmueble;
            FechaInicio = fechaInicio;
            FechaFinalizacion = fechaFinalizacion;
            FechaFirma = fechaFirma;
            Precio = precio;
            EstadoAlquiler = estadoAlquiler;
        }

        // Metodos
        public override string ToString()
        {
            return "Alquiler N°: " + NroAlquiler;
        }
    }
}
