using InmobiliariaBack.Datos;
using InmobiliariaBack.Dominio.Persona;
using InmobiliariaBack.Servicios;
using InmobiliariaBack.Servicios.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InmobiliariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private IGestorCliente gestorCliente;

        public ClienteController()
        {
            gestorCliente = new GestorClientes();
        }

        [HttpPost("inquilinos-deudores")]
        public IActionResult ObtenerClientesDeudores(List<Parametro> listaParametros)
        {
            if (listaParametros == null || listaParametros.Count == 0)
            {
                return BadRequest("Se requiere una lista de parametros");
            }

            return Ok(gestorCliente.ObtenerClientesDeudores(listaParametros));
        }

        [HttpPost("inquilinos-cumplidores")]
        public IActionResult ObtenerClientesCumplidores(List<Parametro> listaParametros)
        {
            if (listaParametros == null || listaParametros.Count == 0)
            {
                return BadRequest("Se requiere una lista de parametros");
            }

            return Ok(gestorCliente.ObtenerClientesCumplidores(listaParametros));
        }

        [HttpGet("clientes")]
        public IActionResult ObtenerClientes()
        {
            return Ok(gestorCliente.ObtenerClientes());
        }

        [HttpGet("cliente")]
        public IActionResult ObtenerProximoCliente()
        {
            return Ok(gestorCliente.ObtenerProximoCliente());
        }

        [HttpPost("insertar-cliente")]
        public IActionResult InsertarClientes(List<Parametro> listaParametros)
        {
            if (listaParametros == null || listaParametros.Count == 0)
            {
                return BadRequest("Se requiere una lista de parametros");
            }

            return Ok(gestorCliente.InsertarClientes(listaParametros));
        }

        [HttpDelete("eliminar-cliente/{codCliente}")]
        public IActionResult EliminarClientes(int codCliente)
        {
            try
            {
                if (codCliente <= 0)
                {
                    return BadRequest("El código del cliente no es válido");
                }

                List<Parametro> listaParametros = new List<Parametro> 
                {
                    new Parametro("@cod_cliente", codCliente)
                };

                int filasAfectadas = gestorCliente.EliminarClientes(listaParametros);

                if (filasAfectadas > 0)
                {
                    return Ok("Cliente eliminado exitosamente");
                }
                else
                {
                    return NotFound($"No se encontró un cliente con el código {codCliente}");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar el cliente: {ex.Message}");
            }
        }

        [HttpPut("modificar-cliente")]
        public IActionResult ModificarClientes(List<Parametro> listaParametros)
        {
            if (listaParametros == null || listaParametros.Count == 0)
            {
                return BadRequest("Se requiere una lista de parametros");
            }

            return Ok(gestorCliente.ModificarClientes(listaParametros));
        }
    }
}
