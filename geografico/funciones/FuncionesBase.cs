using System;

namespace geografico.funciones
{
    public static class FuncionesBase
    {
        public const float radioTierraKm = 6378.0F;

        static float radianes(this float valor)
        {
            return Convert.ToSingle(Math.PI / 180) * valor;
        }

        static double alCuadrado(this double valor)
        {
            return Math.Pow(valor, 2);
        }

        public static double DistanciaKm(float fLat1, float fLon1, float fLat2, float fLon2)
        {
            var difLatitud = (fLat1 - fLat2).radianes();
            var difLongitud = (fLon1 - fLon2).radianes();

            var a = Math.Sin(difLatitud / 2).alCuadrado() +
                      Math.Cos(fLat1.radianes()) *
                      Math.Cos(fLat2.radianes()) *
                      Math.Sin(difLongitud / 2).alCuadrado();

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return Math.Round(radioTierraKm * Convert.ToSingle(c), 3);            
        }

        internal static object DistanciaKm(double latUno)
        {
            throw new NotImplementedException();
        }
    }
}