using geografico.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace geografico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordenadasController : ControllerBase
    {
        public double Index()
        {
            return 1;
        }

        [HttpPost]
        public double getDistancia([FromBody] Distancia coordenadas)
        {

            return 0;
        }
    }
}
