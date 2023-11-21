using InmobiliariaBack.Dominio.Persona;
using InmobiliariaBack.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Datos.Interfaz
{
    public interface IDaoCliente
    {
        int ObtenerProximoCliente();
        List<Cliente> ObtenerClientes();
        List<ClienteDeudorDTO> ObtenerClientesDeudores(List<Parametro> listaParametros);
        List<ClienteCumplidorDTO> ObtenerClientesCumplidores(List<Parametro> listaParametros);
        int InsertarClientes(List<Parametro> listaParametros);
        int ModificarClientes(List<Parametro> listaParametros);
        int EliminarClientes(List<Parametro> listaParametro);
    }
}
