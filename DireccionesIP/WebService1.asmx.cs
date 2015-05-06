using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace DireccionesIP
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string ClaseIP(int ip)
        {
            if(ip<128)
            {
                return "Esta Direccion IP es de Clase A";
            }
            if (ip >= 128 && ip <192)
            {
                return "Esta Direccion IP es de Clase B";
            }
            else 
            {
                return "Esta Direccion IP es de Clase C";
            }
        }
    }
}
