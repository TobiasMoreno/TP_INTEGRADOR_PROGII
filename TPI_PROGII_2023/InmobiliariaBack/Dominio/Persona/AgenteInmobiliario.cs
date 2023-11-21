using InmobiliariaBack.Dominio.Contactos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InmobiliariaBack.Dominio.Persona
{
    public class AgenteInmobiliario : Persona
    {
        // Atributos
        public int CodAgenteInmobiliario { get; set; }
        public DateTime FechaNacimiento { get; set; }

        // Constructor
        public AgenteInmobiliario(int codAgenteInmobiliario, string nombre, string apellido, string cuil, Barrio barrio, string dir, int nroD, List<Contacto> contactos, DateTime fechaNacimiento) :
                                  base(nombre, apellido, cuil, barrio, dir, nroD, contactos)
        {
            CodAgenteInmobiliario = codAgenteInmobiliario;
            FechaNacimiento = fechaNacimiento;
        }
        public AgenteInmobiliario()
        {
            
        }
    }
}
