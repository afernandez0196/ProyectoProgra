using System;

namespace Ulatina.PrograAvanzada.BLAplicacionWeb.Dominio.Acciones
{
    public class Sumar
    {
        public double CalculeLaSuma(double elOperandoUno, double elOperandoDos)
        {
            var laEspecificacion = new Especificaciones.RealiceLaSuma();
            double elResultado = laEspecificacion.Calcule(elOperandoUno, elOperandoDos);
            return elResultado;
        }
    }
}