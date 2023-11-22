using InmobiliariaBack.Datos;
using InmobiliariaBack.Servicios.Interfaz;
using InmobiliariaBack.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace InmobiliariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmuebleController : Controller
    {
        private IGestorInmueble gestorInmueble;

        public InmuebleController()
        {
            gestorInmueble = new GestorInmueble();
        }

        [HttpPost("inmuebles-captados")]
        public IActionResult ObtenerInmueblesCaptados(List<Parametro> listaParametros)
        {
            if (listaParametros == null || listaParametros.Count == 0)
            {
                return BadRequest("Se requiere una lista de parametros");
            }

            return Ok(gestorInmueble.ObtenerInmueblesCaptados(listaParametros));
        }

        [HttpPost("inmuebles-disponibles")]
        public IActionResult ObtenerInmueblesDisponibles(List<Parametro> listaParametros)
        {
            if (listaParametros == null || listaParametros.Count == 0)
            {
                return BadRequest("Se requiere una lista de parametros");
            }

            return Ok(gestorInmueble.ObtenerInmueblesDisponibles(listaParametros));
        }

        [HttpPost("inmuebles-contratos")]
        public IActionResult ObtenerInmueblesContratos(List<Parametro> listaParametros)
        {
            if (listaParametros == null || listaParametros.Count == 0)
            {
                return BadRequest("Se requiere una lista de parametros");
            }

            return Ok(gestorInmueble.ObtenerInmueblesContratos(listaParametros));
        }

        [HttpPost("inmuebles-por-propietario")]
        public IActionResult ObtenerCantInmueblesPorPropietario(List<Parametro> listaParametros)
        {
            if (listaParametros == null || listaParametros.Count == 0)
            {
                return BadRequest("Se requiere una lista de parametros");
            }

            return Ok(gestorInmueble.ObtenerCantInmueblesPorPropietario(listaParametros));
        }

        [HttpGet("inmuebles")]
        public IActionResult ObtenerInmuebles()
        {
            return Ok(gestorInmueble.ObtenerInmuebles());
        }

        [HttpGet("inmueble")]
        public IActionResult ObtenerProximoCliente()
        {
            return Ok(gestorInmueble.ObtenerProximoInmueble());
        }

        [HttpPost("insertar-inmueble")]
        public IActionResult InsertarInmueble(List<Parametro> listaParametros)
        {
            if (listaParametros == null || listaParametros.Count == 0)
            {
                return BadRequest("Se requiere una lista de parametros");
            }

            return Ok(gestorInmueble.InsertarInmueble(listaParametros));
        }
        [HttpDelete("eliminar-inmueble/{codInmueble}")]
        public IActionResult EliminarInmueble(int codInmueble)
        {
            try
            {
                if (codInmueble <= 0)
                {
                    return BadRequest("El código del inmueble no es válido");
                }

                List<Parametro> listaParametros = new List<Parametro>
                {
                    new Parametro("@cod_inmueble", codInmueble)
                };

                int filasAfectadas = gestorInmueble.EliminarInmueble(listaParametros);

                if (filasAfectadas > 0)
                {
                    return Ok("Inmueble eliminado exitosamente");
                }
                else
                {
                    return NotFound($"No se encontró un inmueble con el código {codInmueble}");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar el inmueble: {ex.Message}");
            }
        }
        [HttpPut("modificar-inmueble")]
        public IActionResult ModificarInmueble(List<Parametro> listaParametros)
        {
            if (listaParametros == null || listaParametros.Count == 0)
            {
                return BadRequest("Se requiere una lista de parametros");
            }

            return Ok(gestorInmueble.ModificarInmueble(listaParametros));
        }
    }
}
