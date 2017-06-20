using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.PrograAvanzada.BLAplicacionWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public double Sume(double elOperandoUno, double elOperandoDos)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.Sumar();
            elResultado = laAccion.CalculeLaSuma(elOperandoUno, elOperandoDos);

            return elResultado;
        }

        public double Reste(double elOperandoUno, double elOperandoDos)
        {
            double elResultado = 0;
            //var laAccion = new Dominio.Acciones.Restar();
            //elResultado = laAccion.ObtengaLaFecha();

            return elResultado;
        }

        public double Multiplique(double elOperandoUno, double elOperandoDos)
        {
            double elResultado = 0;
            //var laAccion = new Dominio.Acciones.Multiplicar();
            //elResultado = laAccion.ObtengaLaFecha();

            return elResultado;
        }

        public double Divide(double elOperandoUno, double elOperandoDos)
        {
            double elResultado = 0;
            //var laAccion = new Dominio.Acciones.Dividir();
            //elResultado = laAccion.ObtengaLaFecha();

            return elResultado;
        }

        public string WhatDateIsToday()
        {
            string elResultado;
            var laAccion = new Dominio.Acciones.ObtenerFechaActual();
            elResultado = laAccion.ObtengaLaFecha();

            return elResultado;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
