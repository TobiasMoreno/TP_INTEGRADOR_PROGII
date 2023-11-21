using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio.Inmuebles
{
    public class TipoInmueble
    {
        // Atributos
        public int CodTipoInmueble { get; set; }
        public string ValorTipoInmueble { get; set; }

        // Constructor
        public TipoInmueble(int codTipoInmueble, string valorTipoInmueble)
        {
            CodTipoInmueble = codTipoInmueble;
            ValorTipoInmueble = valorTipoInmueble;
        }
        public TipoInmueble()
        {
            CodTipoInmueble = 0;
            ValorTipoInmueble = "";
        }

        // Metodos
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
