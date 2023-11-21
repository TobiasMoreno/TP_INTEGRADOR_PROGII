using InmobiliariaBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Datos.Interfaz
{
    public interface IDaoBarrio
    {
        List<Barrio> ObtenerCboBarrios();
    }
}
