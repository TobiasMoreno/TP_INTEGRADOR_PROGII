using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InmobiliariaBack.Datos.DAO
{
    public class DaoLogin
    {
        public int Login(string usuario, string contraseña)
        {
            List<Parametro> listaParametro = new List<Parametro>()
            {
                new Parametro("@usuario", usuario),
                new Parametro("@contraseña", contraseña)
            };
            SqlParameter login = DBHelper.ObtenerInstancia().Consultar("SP_IniciarSesion", "@salida", SqlDbType.Int, listaParametro);
            return (int)login.Value;
        }
    }
}
