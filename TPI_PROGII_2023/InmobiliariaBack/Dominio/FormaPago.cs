using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio
{
    public class FormaPago
    {
        public int nroFormaPago { get; set; }
        public string FormadePago { get; set; }
        public float Recargo { get; set; }
        public override string ToString()
        {
            return FormadePago;
        }
    }
}
