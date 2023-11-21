using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.DTO
{
    public class ClienteDeudorDTO
    {
        public string NombreCompleto { get; set; }
        public int NroAlquiler { get; set; }
        public string Inmueble { get; set; }
        public DateTime FechaInicio { get; set; }
        public int MesesAlquiler { get; set; }
        public int CantidadFacturasPagas { get; set; }
        public int CantidadFacturasImpagas { get; set; }
    }
}
