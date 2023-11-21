using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio
{
    public class TipoContrato
    {
        public int CodTipoContrato { get; set; }
        public string ValorTipoContrato { get; set; }
        public TipoContrato(int codTipoContrato, string valorTipoContrato)
        {
            CodTipoContrato = codTipoContrato;
            ValorTipoContrato = valorTipoContrato;
        }
        public override string ToString()
        {
            return ValorTipoContrato;
        }
    }
}
