using InmobiliariaBack.Dominio.Alquileres;
using InmobiliariaBack.Dominio.Contactos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio.Persona
{
    public class Cliente : Persona
    {
        // Atributos
        public int CodCliente { get; set; }
        public int Documento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<Alquiler> Alquileres { get; set; }

        // Constructor
        public Cliente(
            int codCliente, 
            int documento,
            string nombre, 
            string apellido, 
            string cuil, 
            Barrio barrio, 
            string direccion,
            int nroDireccion,
            DateTime fechaRegistro, 
            DateTime fechaNacimiento,
            List<Contacto> contactos, 
            List<Alquiler> alquileres
        ) : base(nombre, apellido, cuil, barrio, direccion, nroDireccion, contactos)
        {
            CodCliente = codCliente;
            Documento = documento;
            FechaRegistro = fechaRegistro;
            FechaNacimiento = fechaNacimiento;
            Alquileres = alquileres;
        }

        public Cliente() : base("nombre", "apellido", "cuil", new Barrio(), "direccion", 0, new List<Contacto>())
        {
            
        }
    }
}
