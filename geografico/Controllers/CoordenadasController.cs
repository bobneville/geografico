using geografico.Models;
using geografico.funciones;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace geografico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordenadasController : ControllerBase
    {
        public string Index()
        {
           string tmp = "{\"latUno\":39.9605400,\"lonUno\":-4.8331900,\"latDos\":40.41831,\"lonDos\":-3.70275}";
           Distancia posicion = JsonSerializer.Deserialize<Distancia>(tmp);
            var distancia = getDistancia(posicion);

            return $"La distancia entre Talavera de la Reina y Madrid es de {distancia} kmts.";
        }

        [HttpPost]
        public double getDistancia([FromBody] Distancia coordenadas)
        {
            return FuncionesBase.DistanciaKm(coordenadas.latUno, coordenadas.lonUno, coordenadas.latDos, coordenadas.lonDos);
          
        }
    }
}
