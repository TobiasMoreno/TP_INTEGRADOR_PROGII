using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Datos
{
    public class DBHelper
    {
        private static DBHelper instancia = null;
        private SqlConnection conexion;
        private string cadenaConexion = "Data Source=DESKTOP-0d1nirp;Initial Catalog=INMOBILIARIA3;Integrated Security=True";

        public DBHelper()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public static DBHelper ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new DBHelper();
            }

            return instancia;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());

            conexion.Close();

            return dataTable;
        }

        public DataTable Consultar(string nombreSP, List<Parametro> listaParametros)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();

            foreach (Parametro parametro in listaParametros)
            {
                if (parametro.Valor == null)
                {
                    comando.Parameters.AddWithValue(parametro.Nombre, DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue(parametro.Nombre, parametro.Valor.ToString());
                }
            }

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());

            conexion.Close();

            return dataTable;
        }

        public SqlParameter Consultar(string nombreSP, string nombreParametro, SqlDbType tipoDato)
        {
            conexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;

            SqlParameter parametroSalida = new SqlParameter();
            parametroSalida.ParameterName = nombreParametro;
            parametroSalida.SqlDbType = tipoDato;
            parametroSalida.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(parametroSalida);
            cmd.ExecuteNonQuery();

            conexion.Close();

            return parametroSalida;
        }

        public SqlParameter Consultar(string nombreSP, string nombreParametro, SqlDbType tipoDato, List<Parametro> listaParametros)
        {
            conexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;

            cmd.Parameters.Clear();

            foreach (Parametro parametro in listaParametros)
            {
                if (parametro.Valor == null)
                {
                    cmd.Parameters.AddWithValue(parametro.Nombre, DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor.ToString());
                }
            }

            SqlParameter parametroSalida = new SqlParameter();
            parametroSalida.ParameterName = nombreParametro;
            parametroSalida.SqlDbType = tipoDato;
            parametroSalida.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(parametroSalida);
            cmd.ExecuteNonQuery();

            conexion.Close();

            return parametroSalida;
        }

        public int Actualizar(string nombreSP, List<Parametro> listaParametros)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();

            foreach (Parametro parametro in listaParametros)
            {
                if (parametro.Valor == null)
                {
                    comando.Parameters.AddWithValue(parametro.Nombre, DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue(parametro.Nombre, parametro.Valor.ToString());
                }
            }
            int filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();

            return filasAfectadas;
        }
    }
}
