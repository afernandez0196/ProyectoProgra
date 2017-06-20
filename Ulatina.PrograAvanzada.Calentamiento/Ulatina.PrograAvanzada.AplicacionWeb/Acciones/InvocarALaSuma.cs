using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.AplicacionWeb.Acciones
{
    public class InvocarALaSuma
    {
        public string CalculeLaSuma (string elOperandoUno, string elOperandoDos)
        {
            string elResultado;

            // parsear el primer elemento
            double elPrimerOperando = Parsear(elOperandoUno);
            // parsear el segundo elemento
            double elSegundoOperando = Parsear(elOperandoDos);
            // instanciar el wcf
            var elCliente = new OperacionesMatematicas.Service1Client();
            // invocar al mètodo del wcf
            var elResultadoNumerico = elCliente.Sume(elPrimerOperando, elSegundoOperando);
            // convertir el resultado a string
            elResultado = elResultadoNumerico.ToString();
            // retornar
            return elResultado;
        }

        private double Parsear(string elNumeroEnString)
        {
            double elResultado;
            double.TryParse(elNumeroEnString, out elResultado);
            return elResultado;
        }
    }
}