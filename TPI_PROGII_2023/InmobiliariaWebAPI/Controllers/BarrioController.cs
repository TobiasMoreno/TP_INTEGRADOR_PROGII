using InmobiliariaBack.Servicios;
using InmobiliariaBack.Servicios.Interfaz;
using Microsoft.AspNetCore.Mvc;

namespace InmobiliariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarrioController : Controller
    {
        private IGestorBarrio gestorBarrio;
        public BarrioController()
        {
            gestorBarrio = new GestorBarrio();
        }
        [HttpGet("barrios")]
        public IActionResult ObtenerAgentes()
        {
            return Ok(gestorBarrio.ObtenerCboBarrio());
        }
    }
}
