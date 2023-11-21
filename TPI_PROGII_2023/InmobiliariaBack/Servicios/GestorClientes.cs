using InmobiliariaBack.Datos;
using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Datos.Interfaz;
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
    public class GestorClientes: IGestorCliente
    {
        private IDaoCliente daoCliente;

        public GestorClientes()
        {
            daoCliente = new DaoCliente();
        }

        public List<ClienteDeudorDTO> ObtenerClientesDeudores(List<Parametro> listaParametros)
        {
            return daoCliente.ObtenerClientesDeudores(listaParametros);
        }
        public List<ClienteCumplidorDTO> ObtenerClientesCumplidores(List<Parametro> listaParametros)
        {
            return daoCliente.ObtenerClientesCumplidores(listaParametros);
        }

        public List<Cliente> ObtenerClientes()
        {
            return daoCliente.ObtenerClientes();
        }

        public int ObtenerProximoCliente()
        {
            return daoCliente.ObtenerProximoCliente();
        }

        public int EliminarClientes(List<Parametro> listaParametros)
        {
            return daoCliente.EliminarClientes(listaParametros);
        }

        public int InsertarClientes(List<Parametro> listaParametros)
        {
            return daoCliente.InsertarClientes(listaParametros);
        }

        public int ModificarClientes(List<Parametro> listaParametros)
        {
            return daoCliente.ModificarClientes(listaParametros);
        }
    }
}
