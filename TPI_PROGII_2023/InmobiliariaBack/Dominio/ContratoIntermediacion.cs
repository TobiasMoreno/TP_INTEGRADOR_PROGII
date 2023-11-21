using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariaBack.Dominio.Inmuebles;

namespace InmobiliariaBack.Dominio
{
    public class ContratoIntermediacion
    {
        public int CodContratoIntermediacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public float PorcentajeComision { get; set; }
        public Inmueble Inmueble { get; set; }
        public TipoContrato TipoContrato { get; set; }
        public bool Activo { get; set; }
        public ContratoIntermediacion(int codContratoIntermediacion,DateTime fechaInicio, DateTime fechaFinalizacion, 
                                      float porcentajeComision, Inmueble inmueble, TipoContrato tipoContrato, bool activo)
        {
            CodContratoIntermediacion = codContratoIntermediacion;
            FechaInicio = fechaInicio;
            FechaFinalizacion = fechaFinalizacion;
            PorcentajeComision = porcentajeComision;
            Inmueble = inmueble;
            TipoContrato = tipoContrato;
            Activo = activo;
        }
        public override string ToString()
        {
            return CodContratoIntermediacion.ToString();
        }

    }
}
