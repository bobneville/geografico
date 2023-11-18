using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace geografico.Models
{
    public class Posicion
    {
        public Posicion(float latitud1, float longitud1, float latitud2, float longitud2)
        {
            Latitud1 = latitud1;
            Longitud1 = longitud1;
            Latitud2 = latitud2;
            Longitud2 = longitud2;
        }
        public float Latitud1 { get; set; }
        public float Longitud1 { get; set; }
        public float Latitud2 { get; set; }
        public float Longitud2 { get; set; }
    }
}
