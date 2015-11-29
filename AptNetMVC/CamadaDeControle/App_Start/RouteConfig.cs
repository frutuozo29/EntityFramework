using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CamadaDeControle
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "ProdutoListarPorPreco",
               url: "Produto/Listar/{PrecoMinimo}/{PrecoMaximo}",
               defaults: new { contoller = "Produto", action = "Listar" } 
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Produto", action = "Listar", id = UrlParameter.Optional }
            );
        }
    }
}
