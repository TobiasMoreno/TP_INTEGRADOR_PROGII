using InmobiliariaBack.Dominio.Contactos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio.Persona
{
    public class Propietario : Persona
    {
        // Atributos
        public int CodPropietario { get; set; }
        public List<ContratoIntermediacion> ContratosIntermediacion { get; set; }

        // Constructor
        public Propietario(int codPropietario, string nombre, string apellido, string cuil, Barrio barrio, string direccion, int nroDireccion, List<Contacto> contactos, List<ContratoIntermediacion> contratosIntermediacion) :
                           base(nombre, apellido, cuil, barrio, direccion, nroDireccion, contactos)
        {
            CodPropietario = codPropietario;
            ContratosIntermediacion = contratosIntermediacion;
        }
    }
}
