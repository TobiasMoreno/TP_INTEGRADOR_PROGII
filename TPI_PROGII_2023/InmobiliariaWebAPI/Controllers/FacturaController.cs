using InmobiliariaBack.Servicios.Interfaz;
using InmobiliariaBack.Servicios;
using Microsoft.AspNetCore.Mvc;
using InmobiliariaBack.Datos;
using InmobiliariaBack.Dominio.Facturas;
using System.Diagnostics;

namespace InmobiliariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : Controller
    {
        private IGestorFactura gestorFactura;

        public FacturaController()
        {
            gestorFactura = new GestorFactura();
        }

        [HttpGet("proxima-factura")]
        public IActionResult ObtenerProximaFactura()
        {
            return Ok(gestorFactura.ObtenerProximaFactura());
        }

        [HttpGet("proximo-detalle-venta")]
        public IActionResult ObtenerProximoDetalleVenta()
        {
            return Ok(gestorFactura.ObtenerProximoDetalleVenta());
        }

        [HttpGet("proximo-detalle-alquiler")]
        public IActionResult ObtenerProximoDetalleAlquiler()
        {
            return Ok(gestorFactura.ObtenerProximoDetalleAlquiler());
        }

        [HttpPost("insertar-factura")]
        public IActionResult InsertarFactura(Factura oFactura)
        {
            try
            {
                var result = gestorFactura.InsertarFactura(oFactura);
                if (result != 0)
                {
                    return Ok("La factura se insertó con éxito.");
                }
                else
                {
                    return BadRequest("Error al insertar la factura.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, "Error interno del servidor.");
            }
        }
    }
}
