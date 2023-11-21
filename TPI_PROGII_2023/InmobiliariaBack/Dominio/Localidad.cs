using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio
{
    public class Localidad
    {
        public int CodLocalidad { get; set; }
        public string NombreLocalidad { get; set; }
        public Localidad()
        {
            CodLocalidad = 0;
            NombreLocalidad = "";
        }
        public Localidad(int codLocalidad, string nombreLocalidad)
        {
            CodLocalidad = codLocalidad;
            NombreLocalidad = nombreLocalidad;
        }
        public override string ToString()
        {
            return NombreLocalidad;
        }
    }
}
