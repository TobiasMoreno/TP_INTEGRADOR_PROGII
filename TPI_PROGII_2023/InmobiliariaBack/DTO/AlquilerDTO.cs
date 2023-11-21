using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.DTO
{
    public class AlquilerDTO
    {
        public int CodAlquiler { get; set; }
        public string NombreCompletoCliente { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinalizacion { get; set; }
        public string Resumen { get; set; }

        public AlquilerDTO(int codAlquiler, string nombreCliente, string fechaInicio, string fechaFinalizacion)
        {
            CodAlquiler = codAlquiler; 
            NombreCompletoCliente = nombreCliente;
            FechaInicio = fechaInicio;
            FechaFinalizacion = fechaFinalizacion;
            Resumen = $"{codAlquiler}. {NombreCompletoCliente}: {fechaInicio} - {fechaFinalizacion}";
        }
    }
}
