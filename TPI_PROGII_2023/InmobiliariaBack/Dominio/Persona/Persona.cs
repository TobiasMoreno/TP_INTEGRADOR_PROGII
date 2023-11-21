using InmobiliariaBack.Dominio.Contactos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio.Persona
{
    public abstract class Persona
    {
        // Atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto { get; set; }
        public string Cuil { get; set; }
        public Barrio Barrio { get; set; }
        public string Direccion { get; set; }
        public int NroDireccion { get; set; }
        public List<Contacto> Contactos { get; set; }

        // Constructor
        public Persona(string nombre, string apellido, string cuil, Barrio barrio, string direccion, int nroDireccion, List<Contacto> contactos)
        {
            Nombre = nombre;
            Apellido = apellido;
            NombreCompleto = nombre + " " + apellido;
            Cuil = cuil;
            Barrio = barrio;
            Direccion = direccion;
            NroDireccion = nroDireccion;
            Contactos = contactos;
        }
        public Persona()
        {
            
        }

        // Metodos
        public override string ToString()
        {
            return Nombre + Apellido;
        }
    }
}
