using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Validaciones
{
    public class TamanosMatriz
    {
        public bool LaMatrizEsCuadrada (double [,] laMatriz)
        {
            bool elResultado = false;
            var laCantidadDeColumnas = laMatriz.GetLength(1);
            var laCantidadDeFilas = laMatriz.GetLength(0);
            elResultado = (laCantidadDeColumnas == laCantidadDeFilas);
            return elResultado;
        }

        public bool LasMatricesSonIguales(double[,] laMatrizUno, double[,] laMatrizDos)
        {
            var laCantidadDeColumnasDeLaMatrizUno = laMatrizUno.GetLength(1);
            var laCantidadDeFilasDeLaMatrizUno = laMatrizUno.GetLength(0);
            var laCantidadDeColumnasDeLaMatrizDos = laMatrizDos.GetLength(1);
            var laCantidadDeFilasDeLaMatrizDos = laMatrizDos.GetLength(0);
            bool elResultado = ((laCantidadDeColumnasDeLaMatrizUno == laCantidadDeColumnasDeLaMatrizDos) && (laCantidadDeFilasDeLaMatrizUno == laCantidadDeFilasDeLaMatrizDos));
            if (elResultado == true)
            {
                // primer paso: recorre las columnas
                for (int i = 0; elResultado && i < laCantidadDeColumnasDeLaMatrizDos; i++)
                {

                    // segundo paso: recorre las filas
                    for (int j = 0; elResultado && j < laCantidadDeFilasDeLaMatrizDos; j++)
                    {
                        elResultado = laMatrizUno[j, i] == laMatrizDos [j, i];
                    }
                }
            }

            return elResultado;
        }


    }
}