using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.DTO
{
    public class InflacionAlquilerDTO
    {
        public double PromedioDesde { get; set; }
        public double PromedioHasta { get; set; }
        public double Diferencia { get; set; }
        public string PorcentajeAumento { get; set; }
    }
}
