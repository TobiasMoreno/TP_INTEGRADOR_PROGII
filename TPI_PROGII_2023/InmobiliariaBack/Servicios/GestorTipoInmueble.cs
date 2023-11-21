using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Datos.Interfaz;
using InmobiliariaBack.Dominio.Inmuebles;
using InmobiliariaBack.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Servicios
{
    public class GestorTipoInmueble : IGestorTipoInmueble
    {
        private IDaoTipoInmueble daoTipoInmueble;
        public GestorTipoInmueble()
        {
            daoTipoInmueble = new DaoTipoInmueble();
        }
        public List<TipoInmueble> ObtenerCboTiposInmuebles()
        {
            return daoTipoInmueble.ObtenerCboTipoInmueble();
        }
    }
}
