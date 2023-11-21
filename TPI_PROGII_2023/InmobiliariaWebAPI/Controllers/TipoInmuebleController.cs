using InmobiliariaBack.Servicios.Interfaz;
using InmobiliariaBack.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace InmobiliariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoInmuebleController : Controller
    {

        private IGestorTipoInmueble gestorTipo;
        public TipoInmuebleController()
        {
            gestorTipo = new GestorTipoInmueble();
        }
        [HttpGet("tipo-inmuebles")]
        public IActionResult ObtenerTipoInmuebles()
        {
            return Ok(gestorTipo.ObtenerCboTiposInmuebles());
        }
    }
}
