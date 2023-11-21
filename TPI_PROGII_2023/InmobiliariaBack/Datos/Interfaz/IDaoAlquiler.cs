using InmobiliariaBack.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Datos.Interfaz
{
    public interface IDaoAlquiler
    {
        List<InflacionAlquilerDTO> ObtenerPromediosAlquileres(List<Parametro> listaParametros);
        List<AlquilerDTO> ObtenerAlquileres();
    }
}
