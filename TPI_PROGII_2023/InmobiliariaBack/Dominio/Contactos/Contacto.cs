using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio.Contactos
{
    public class Contacto
    {
        // Atributos
        public int CodContacto { get; set; }
        public string ValorContacto { get; set; }
        public TipoContacto TipoContacto { get; set; }

        // Constructor
        public Contacto(int codContacto, string valorContacto, TipoContacto tipoContacto)
        {
            CodContacto = codContacto;
            ValorContacto = valorContacto;
            TipoContacto = tipoContacto;
        }

        // Metodos
        public override string ToString()
        {
            return base.ToString() + CodContacto + ValorContacto;
        }
    }
}
