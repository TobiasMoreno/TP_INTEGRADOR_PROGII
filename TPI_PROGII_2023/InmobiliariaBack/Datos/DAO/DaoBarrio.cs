using InmobiliariaBack.Dominio.Contactos;
using InmobiliariaBack.Dominio.Persona;
using InmobiliariaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariaBack.Datos.Interfaz;

namespace InmobiliariaBack.Datos.DAO
{
    public class DaoBarrio : IDaoBarrio
    {
        public List<Barrio> ObtenerCboBarrios()
        {
            List<Barrio> listaBarrios = new List<Barrio>();

            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_BARRIOS");

            foreach (DataRow row in dataTable.Rows)
            {
                Barrio oBarrio = new(
                    Convert.ToInt32(row["cod_barrio"]),
                    Convert.ToString(row["nom_barrio"]),
                    new Localidad()
                );

                listaBarrios.Add(oBarrio);
            }

            return listaBarrios;
        }
    }
}
