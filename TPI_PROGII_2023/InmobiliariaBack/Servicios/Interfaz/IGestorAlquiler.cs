using InmobiliariaBack.Datos;
using InmobiliariaBack.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Servicios.Interfaz
{
    public interface IGestorAlquiler
    {
        List<InflacionAlquilerDTO> ObtenerPromediosAlquileres(List<Parametro> listaParametros);
        List<AlquilerDTO> ObtenerAlquileres();
    }
}
