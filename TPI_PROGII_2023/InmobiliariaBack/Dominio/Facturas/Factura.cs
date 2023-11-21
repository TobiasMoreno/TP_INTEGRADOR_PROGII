using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariaBack.Datos.DAO;
using InmobiliariaBack.Dominio.Alquileres;
using InmobiliariaBack.Dominio.Persona;

namespace InmobiliariaBack.Dominio.Facturas
{
    public class Factura
    {
        // Atributos
        public int NroFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public List<DetalleFactura> DetallesFactura { get; set; }
        public List<DetalleAlquiler> DetallesAlquiler { get; set; }
        public AgenteInmobiliario AgenteInmobiliario { get; set; }
        public Cliente Cliente { get; set; }
        public float ComisionCliente { get; set; }
        public List<FormaPago> FormasPago { get; set; }

        // Constructor
        public Factura(int nroFactura, DateTime fechaFactura, List<DetalleFactura> detallesFactura, List<DetalleAlquiler> detallesAlquiler,
                        AgenteInmobiliario agenteInmobiliario, Cliente cliente, float comisionCliente, List<FormaPago> formasPago)
        {
            NroFactura = nroFactura;
            FechaFactura = fechaFactura;
            DetallesFactura = detallesFactura;
            DetallesAlquiler = detallesAlquiler;
            AgenteInmobiliario = agenteInmobiliario;
            Cliente = cliente;
            ComisionCliente = comisionCliente;
            FormasPago = formasPago;
        }

        public Factura()
        {
            DetallesFactura = new List<DetalleFactura>();
            DetallesAlquiler = new List<DetalleAlquiler>();
        }

        // Metodos
        public void AgregarDetalle(bool esVenta, DetalleAlquiler detalleAlquiler, DetalleFactura detalleVenta)
        {
            if (esVenta)
            {
                DetallesFactura.Add(detalleVenta);
            }
            else
            {
                DetallesAlquiler.Add(detalleAlquiler);
            }
        }

        public void QuitarDetalle(bool esVenta, int indice)
        {
            if (esVenta)
            {
                DetallesFactura.RemoveAt(indice);
            }
            else
            {
                DetallesAlquiler.RemoveAt(indice);
            }
        }

        public override string ToString()
        {
            return NroFactura.ToString();
        }
    }
}
