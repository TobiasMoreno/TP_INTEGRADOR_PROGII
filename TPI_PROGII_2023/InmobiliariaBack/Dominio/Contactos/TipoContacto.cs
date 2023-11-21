using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio.Contactos
{
    public class TipoContacto
    {
        // Atributos
        public int CodTipoContacto { get; set; }
        public string NombreTipoContacto { get; set; }

        // Constructor
        public TipoContacto(int codTipoContacto, string nombreTipoContacto)
        {
            CodTipoContacto = codTipoContacto;
            NombreTipoContacto = nombreTipoContacto;
        }

        // Metodos
        public override string ToString()
        {
            return NombreTipoContacto;
        }
    }
}
