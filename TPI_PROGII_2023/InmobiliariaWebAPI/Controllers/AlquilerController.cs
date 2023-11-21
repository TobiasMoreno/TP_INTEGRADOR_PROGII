using InmobiliariaBack.Datos;
using InmobiliariaBack.Servicios.Interfaz;
using InmobiliariaBack.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace InmobiliariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : Controller
    {
        private IGestorAlquiler gestorAlquiler;

        public AlquilerController()
        {
            gestorAlquiler = new GestorAlquiler();
        }

        [HttpPost("promedios-alquileres")]
        public IActionResult ObtenerClientesDeudores(List<Parametro> listaParametros)
        {
            if (listaParametros == null || listaParametros.Count == 0)
            {
                return BadRequest("Se requiere una lista de parametros");
            }

            return Ok(gestorAlquiler.ObtenerPromediosAlquileres(listaParametros));
        }

        [HttpGet("alquileres")]
        public IActionResult ObtenerAlquileres()
        {
            return Ok(gestorAlquiler.ObtenerAlquileres());
        }
    }
}
