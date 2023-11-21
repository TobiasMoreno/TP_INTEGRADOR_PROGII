using InmobiliariaBack.Datos.Interfaz;
using InmobiliariaBack.Dominio;
using InmobiliariaBack.Dominio.Inmuebles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Datos.DAO
{
    public class DaoTipoInmueble : IDaoTipoInmueble
    {
        public List<TipoInmueble> ObtenerCboTipoInmueble()
        {

            List<TipoInmueble> listaTipoInmuebles = new List<TipoInmueble>();
            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_INMUEBLES");

            foreach (DataRow dr in dataTable.Rows)
            {
                TipoInmueble oTipoInmueble = new TipoInmueble
                (
                    Convert.ToInt32(dr["cod_tipo_inmueble"]),
                    Convert.ToString(dr["tipo_inmueble"])
                );

                listaTipoInmuebles.Add(oTipoInmueble);
            }
            return listaTipoInmuebles;
        }
    }
}
