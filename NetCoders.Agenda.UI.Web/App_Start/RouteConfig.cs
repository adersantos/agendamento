using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NetCoders.Agenda.UI.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
<<<<<<< HEAD
                defaults: new { controller = "Agenda", action = "Index", id = UrlParameter.Optional }
=======
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
>>>>>>> 199b448c761e984def3565897bfc271d2d9a1f5a
            );
        }
    }
}
