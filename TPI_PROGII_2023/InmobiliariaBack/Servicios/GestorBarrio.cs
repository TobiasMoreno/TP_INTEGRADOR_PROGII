using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Datos.Interfaz;
using InmobiliariaBack.Dominio;
using InmobiliariaBack.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Servicios
{
    public class GestorBarrio : IGestorBarrio
    {
        private IDaoBarrio daoBarrio;

        public GestorBarrio()
        {
            daoBarrio = new DaoBarrio();
        }
        public List<Barrio> ObtenerCboBarrio()
        {
            return daoBarrio.ObtenerCboBarrios();
        }
    }
}
