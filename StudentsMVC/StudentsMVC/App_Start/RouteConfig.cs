using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StudentsMVC {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{name}/{numTimes}",
                defaults: new { controller = "Home", action = "Index", name ="Calin", numTimes = UrlParameter.Optional }
            );

            //Route for Test Controller
            routes.MapRoute(
                name: "Test",
                url: "{Test}/{action}/{name}"
            );

            routes.MapRoute(
                name: "HelloWorld",
                url:"{controller}/{action}/{name}/{numTimes}"
            );
        }
    }
}
