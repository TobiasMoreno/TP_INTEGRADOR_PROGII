using InmobiliariaBack.Datos.Interfaz;
using InmobiliariaBack.Dominio.Alquileres;
using InmobiliariaBack.Dominio.Contactos;
using InmobiliariaBack.Dominio;
using InmobiliariaBack.Dominio.Persona;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Datos.DAO
{
    public class DaoAgente : IDaoAgente
    {
        public List<AgenteInmobiliario> ObtenerAgentes()
        {
            List<AgenteInmobiliario> listaAgentes = new List<AgenteInmobiliario>();

            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_AGENTES");

            foreach (DataRow row in dataTable.Rows)
            {
                AgenteInmobiliario oAgente = new AgenteInmobiliario(
                    Convert.ToInt32(row["cod_agente_inmobiliario"]),
                    Convert.ToString(row["nombre"]),
                    Convert.ToString(row["apellido"]),
                    Convert.ToString(row["cuil"]),
                    new Barrio(),
                    Convert.ToString(row["direccion"]),
                    Convert.ToInt32(row["nro_direccion"]),
                    new List<Contacto>(),
                    Convert.ToDateTime(row["fecha_nacimiento"])
                );

                listaAgentes.Add(oAgente);
            }

            return listaAgentes;
        }
    }
}
