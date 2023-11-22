using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Datos.Interfaz;
using InmobiliariaBack.Datos;
using InmobiliariaBack.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariaBack.Servicios.Interfaz;
using InmobiliariaBack.Dominio.Inmuebles;

namespace InmobiliariaBack.Servicios
{
    public class GestorInmueble : IGestorInmueble
    {
        private IDaoInmueble daoInmueble;

        public GestorInmueble()
        {
            daoInmueble = new DaoInmueble();
        }

        public int ObtenerProximoInmueble()
        {
            return daoInmueble.ObtenerProximoInmueble();
        }
        public List<InmuebleCaptadoDTO> ObtenerInmueblesCaptados(List<Parametro> listaParametros)
        {
            return daoInmueble.ObtenerInmueblesCaptados(listaParametros);
        }

        public List<InmuebleDisponibleDTO> ObtenerInmueblesDisponibles(List<Parametro> listaParametros)
        {
            return daoInmueble.ObtenerInmueblesDisponibles(listaParametros);
        }

        public List<InmuebleContratoDTO> ObtenerInmueblesContratos(List<Parametro> listaParametros)
        {
            return daoInmueble.ObtenerInmueblesContratos(listaParametros);
        }

        public List<CantInmuPropDTO> ObtenerCantInmueblesPorPropietario(List<Parametro> listaParametros)
        {
            return daoInmueble.ObtenerCantInmueblesPorPropietario(listaParametros);
        }

        public List<Inmueble> ObtenerInmuebles()
        {
            return daoInmueble.ObtenerInmuebles();
        }

        public int InsertarInmueble(List<Parametro> listaParametros)
        {
            return daoInmueble.InsertarInmueble(listaParametros);
        }

        public int ModificarInmueble(List<Parametro> listaParametros)
        {
            return daoInmueble.ModificarInmueble(listaParametros);
        }

        public int EliminarInmueble(List<Parametro> listaParametros)
        {
            return daoInmueble.EliminarInmueble(listaParametros);
        }

    }
}
