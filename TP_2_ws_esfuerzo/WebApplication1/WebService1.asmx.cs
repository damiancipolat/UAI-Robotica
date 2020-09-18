using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceEsfuerzo : System.Web.Services.WebService
    {
        public ServiceEsfuerzo() {
        }
        
        private double CalcularEsfuerzo(double l, double ck, double td)
        {
            return (Math.Pow(l, 3) / (Math.Pow(ck, 3) * Math.Pow(td, 4)));
        }

        [WebMethod]
        public double Calcular()
        {
            double L = Convert.ToDouble(Session["L"].ToString());
            double TD = Convert.ToDouble(Session["TD"].ToString());
            double CK = Convert.ToDouble(Session["CK"].ToString());

            return this.CalcularEsfuerzo(L,CK,TD);
        }
    }
}
