using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio.Inmuebles
{
    public class Inmueble
    {
        // Atributos
        public int CodInmueble { get; set; }
        public double Superficie { get; set; }
        public int AñoConstruccion { get; set; }
        public string Descripcion { get; set; }
        public TipoInmueble TipoInmueble { get; set; }
        public Barrio Barrio { get; set; }
        public string Direccion { get; set; }
        public int NroDireccion { get; set; }
        public double Precio { get; set; }

        // Constructor
        public Inmueble(int codInmueble, double superficie, int añoConstruccion, string descripcion, TipoInmueble tipoInmueble, Barrio barrio,
                        string direccion, int nroDireccion, double precio)
        {
            CodInmueble = codInmueble;
            Superficie = superficie;
            AñoConstruccion = añoConstruccion;
            Descripcion = descripcion;
            TipoInmueble = tipoInmueble;
            Barrio = barrio;
            Direccion = direccion;
            NroDireccion = nroDireccion;
            Precio = precio;
        }

        public Inmueble()
        {
            
        }

        // Metodos
        public override string ToString()
        {
            return Descripcion;
        }

    }
}
