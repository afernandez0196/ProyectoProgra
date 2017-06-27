using System;

namespace Especificaciones
{
    internal class Transpuesta
    {
        public Transpuesta()
        {
        }

        internal double[,] CalcularTranspuesta(double[,] laMatriz)
        {
            var laCantidadDeColumnas = laMatriz.GetLength(1);
            var laCantidadDeFilas = laMatriz.GetLength(0);
            double[,] elResultado = new double [laCantidadDeColumnas, laCantidadDeFilas];
            // primer paso: recorre las columnas
            for (int i = 0; i < laCantidadDeColumnas; i++)
            {

                // segundo paso: recorre las filas
                for (int j = 0; j < laCantidadDeFilas; j++)
                {
                    elResultado[i, j] = laMatriz[j, i];
                }
            }
            return (elResultado);
        }
    }
}