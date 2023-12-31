﻿using InmobiliariaBack.Datos;
using InmobiliariaBack.Dominio.Inmuebles;
using InmobiliariaBack.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaBack.Servicios.Interfaz
{
    public interface IGestorInmueble
    {
        int ObtenerProximoInmueble();
        List<Inmueble> ObtenerInmuebles();
        List<InmuebleCaptadoDTO> ObtenerInmueblesCaptados(List<Parametro> listaParametros);
        List<InmuebleDisponibleDTO> ObtenerInmueblesDisponibles(List<Parametro> listaParametros);
        List<InmuebleContratoDTO> ObtenerInmueblesContratos(List<Parametro> listaParametros);
        List<CantInmuPropDTO> ObtenerCantInmueblesPorPropietario(List<Parametro> listaParametros);
        int InsertarInmueble(List<Parametro> listaParametros);
        int ModificarInmueble(List<Parametro> listaParametros);
        int EliminarInmueble(List<Parametro> listaParametros);
    }
}
