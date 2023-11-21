using InmobiliariaBack.Datos.Interfaz;
using InmobiliariaBack.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Datos.DAO
{
    public class DaoAlquiler : IDaoAlquiler
    {
        public List<AlquilerDTO> ObtenerAlquileres()
        {
            List<AlquilerDTO> listaAlquileres = new List<AlquilerDTO>();

            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_ALQUILERES");

            foreach (DataRow row in dataTable.Rows)
            {
                DateTime fechaInicio = Convert.ToDateTime(row["fecha_inicio"]);
                DateTime fechaFinalizacion = Convert.ToDateTime(row["fecha_finalizacion"]);

                AlquilerDTO oAlquiler = new AlquilerDTO(
                    Convert.ToInt32(row["cod_alquiler"]),
                    Convert.ToString(row["nombre_cliente"]),
                    fechaInicio.ToShortDateString(),
                    fechaFinalizacion.ToShortDateString()
                );

                listaAlquileres.Add(oAlquiler); 
            }

            return listaAlquileres;
        }

        public List<InflacionAlquilerDTO> ObtenerPromediosAlquileres(List<Parametro> listaParametros)
        {
            List<InflacionAlquilerDTO> listaInflacion = new List<InflacionAlquilerDTO>();

            DataTable dataTable = DBHelper.ObtenerInstancia().Consultar("SP_INFLACION_ALQUILER", listaParametros);
            Console.WriteLine($"Promedio del precio en {listaParametros[0].Valor}");
            Console.WriteLine($"Promedio del precio en {listaParametros[1].Valor}");

            foreach (DataRow row in dataTable.Rows)
            {
                InflacionAlquilerDTO oInflacion = new InflacionAlquilerDTO();

                object promedioDesde = row[$"Promedio del precio en {listaParametros[0].Valor}"];
                oInflacion.PromedioDesde = (promedioDesde != DBNull.Value) ? Convert.ToDouble(promedioDesde) : 0;

                object promedioHasta = row[$"Promedio del precio en {listaParametros[1].Valor}"];
                oInflacion.PromedioHasta = (promedioHasta != DBNull.Value) ? Convert.ToDouble(promedioHasta) : 0;

                object diferencia = row["Diferencia"];
                oInflacion.Diferencia = (diferencia != DBNull.Value) ? Convert.ToDouble(diferencia) : 0;

                object porcentajeAumento = row["Porcentaje de aumento"];
                oInflacion.PorcentajeAumento = (porcentajeAumento != DBNull.Value) ? Convert.ToString(porcentajeAumento) : "Sin datos";

                listaInflacion.Add(oInflacion);
            }

            return listaInflacion;
        }
    }
}
