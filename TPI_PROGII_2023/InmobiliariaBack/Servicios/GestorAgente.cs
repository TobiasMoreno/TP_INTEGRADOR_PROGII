using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Datos.Interfaz;
using InmobiliariaBack.Datos;
using InmobiliariaBack.Dominio.Persona;
using InmobiliariaBack.DTO;
using InmobiliariaBack.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Servicios
{
    public class GestorAgente : IGestorAgente
    {
        private IDaoAgente daoAgente;

        public GestorAgente()
        {
            daoAgente = new DaoAgente();
        }

        public List<AgenteInmobiliario> ObtenerAgentes()
        {
            return daoAgente.ObtenerAgentes();
        }
    }
}
