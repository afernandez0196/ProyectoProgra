using System;

namespace Acciones
{
    internal class Transponer
    {
        public Transponer()
        {
        }

        internal double [,]  CalcularTranspuesta(double[,] laMatriz)
        {
            var laEspecificacion = new Especificaciones.Transpuesta();
            var elResultado = laEspecificacion.CalcularTranspuesta(laMatriz);
            return elResultado;
        }
    }
}