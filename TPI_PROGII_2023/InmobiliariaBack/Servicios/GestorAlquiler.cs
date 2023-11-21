using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Datos.Interfaz;
using InmobiliariaBack.Datos;
using InmobiliariaBack.DTO;
using InmobiliariaBack.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Servicios
{
    public class GestorAlquiler : IGestorAlquiler
    {
        private IDaoAlquiler daoAlquiler;

        public GestorAlquiler()
        {
            daoAlquiler = new DaoAlquiler();
        }

        public List<AlquilerDTO> ObtenerAlquileres()
        {
            return daoAlquiler.ObtenerAlquileres();
        }

        public List<InflacionAlquilerDTO> ObtenerPromediosAlquileres(List<Parametro> listaParametros)
        {
            return daoAlquiler.ObtenerPromediosAlquileres(listaParametros);
        }
    }
}
