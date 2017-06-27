using System;

namespace Especificaciones
{
    internal class Simetrica
    {
        public Simetrica()
        {
        }

        internal bool CalcularSimetrica(double[,] laMatriz)
        {
            bool elResultado = false;
            // paso 1: determinar si la matriz es cuadrada
            var laValidacion = new Validaciones.TamanosMatriz();
            bool laMatrizEsCuadrada = laValidacion.LaMatrizEsCuadrada(laMatriz);
            // paso 2:  si es cuadrada, 
            // calcule la transpuesta
            var laEspecificacionTranspuesta = new Especificaciones.Transpuesta();
            double[,] laMatrizTranspuesta = laEspecificacionTranspuesta.CalcularTranspuesta(laMatriz);
            // paso 3:  comparar si son iguales
            elResultado = laValidacion.LasMatricesSonIguales(laMatriz, laMatrizTranspuesta);

            return elResultado;
        }
    }
}