using InmobiliariaBack.Datos;
using InmobiliariaBack.Dominio.Inmuebles;
using InmobiliariaBack.Dominio;

namespace InmobiliariaWebAPI.Modelos
{
    public class ModeloInmueble
    {
        public List<Parametro> ListaParametros { get; set; }
        public Inmueble Inmueble { get; set; }
        public ContratoIntermediacion ContratoIntermediacion { get; set; }
    }
}
