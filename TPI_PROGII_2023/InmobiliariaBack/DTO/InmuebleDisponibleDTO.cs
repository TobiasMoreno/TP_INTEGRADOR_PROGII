using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.DTO
{
    public class InmuebleDisponibleDTO
    {
        public string Localidad { get; set; }
        public string Barrio { get; set; }
        public string DescInmueble { get; set; }
        public string DirecInmueble { get; set; }
        public int NroDireccion { get; set; }
        public float Precio { get; set; }
        public string Transaccion { get; set; }
    }
}
