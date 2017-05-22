using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RegistrosBeautyCenter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "CiudadesList",
                "Home/Ciudades/List/{ProvinciaId}",
                new { controller = "Home", action = "CiudadesList", ProvinciaId = "" });

            routes.MapRoute(
                "ProvinciaList",
                "Home/Provincias/List",
                new { controller = "Home", action = "ProvinciaList" });

            //BLL.ServiciosBLL.Guardar();
            BLL.ProvinciasBLL.Guardar();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
