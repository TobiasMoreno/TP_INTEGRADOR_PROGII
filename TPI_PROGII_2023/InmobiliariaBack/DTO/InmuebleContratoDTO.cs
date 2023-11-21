using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.DTO
{
    public class InmuebleContratoDTO
    {
        public string NombrePropietario { get; set; }
        public string DescripcionInmueble { get; set; }
        public string Barrio { get; set; }
        public string Direccion { get; set; }
        public int Altura { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public string Transaccion { get; set; }
    }
}
