using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio
{
    public class Barrio
    {
        public int CodBarrio { get; set; }
        public string NombreBarrio { get; set; }
        public Localidad Localidad { get; set; }
        public Barrio()
        {
            CodBarrio = 0;
            NombreBarrio = "";
            Localidad = new Localidad();
        }
        public Barrio(int codBarrio, string nombreBarrio, Localidad localidad)
        {
            CodBarrio = codBarrio;
            NombreBarrio = nombreBarrio;
            Localidad = localidad;
        }
        public override string ToString()
        {
            return NombreBarrio;
        }
    }
}
