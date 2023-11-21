using InmobiliariaBack.Servicios.Interfaz;
using InmobiliariaBack.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace InmobiliariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenteController : Controller
    {
        private IGestorAgente gestorAgente;

        public AgenteController()
        {
            gestorAgente = new GestorAgente();
        }

        [HttpGet("agentes")]
        public IActionResult ObtenerAgentes()
        {
            return Ok(gestorAgente.ObtenerAgentes());
        }
    }
}
