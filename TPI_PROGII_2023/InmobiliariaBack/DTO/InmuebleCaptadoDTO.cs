using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.DTO
{
    public class InmuebleCaptadoDTO
    {
        public string Descripcion { get; set; }
        public string NombreCompletoAgente { get; set; }
        public string NombreCompletoCliente { get; set; }
        public int Año { get; set; }
        public string NroFactura { get; set; }
        public string CostoVenta { get; set; }
        public string ComisionPorContrato { get; set; }
        public string ComisionPorCliente { get; set; }
        public string TotalGanancias { get; set; }
    }
}
