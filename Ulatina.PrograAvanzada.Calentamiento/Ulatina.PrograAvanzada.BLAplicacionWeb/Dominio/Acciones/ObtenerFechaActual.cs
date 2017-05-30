using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.BLAplicacionWeb.Dominio.Acciones
{
    public class ObtenerFechaActual
    {
        public string ObtengaLaFecha ()
        {
            //Ulatina.PrograAvanzada.BLAplicacionWeb.Dominio.Especificaciones.ObtengaFecha laEspecificacion = new Ulatina.PrograAvanzada.BLAplicacionWeb.Dominio.Especificaciones.ObtengaFecha();
            // Especificaciones.ObtengaFecha laEspecificacion = new Especificaciones.ObtengaFecha();
            var laEspecificacion = new Especificaciones.ObtengaFecha();
            string laFecha = laEspecificacion.FormatearUnaFecha(DateTime.Now, "dd/mm/yyyy");
            return laFecha;
        }
    }
}