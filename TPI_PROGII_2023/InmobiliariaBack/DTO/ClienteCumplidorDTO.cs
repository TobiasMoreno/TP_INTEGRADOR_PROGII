using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.DTO
{
    public class ClienteCumplidorDTO
    {
        public string NombleCliente { get; set; }
        public string Inmueble { get; set; }
        public string Barrio { get; set; }
        public string Direccion { get; set; }
        public int Altura { get; set; }
    }
}
