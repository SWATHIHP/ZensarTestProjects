using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LoginScenario
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
           "UserDetails",
         "Details/{Id}",
         new { controller = "UserMvc", action = "Details"});

            routes.MapRoute(
          "EditUser",
          "Edit/{Id}",
          new { controller = "UserMvc", action = "Edit" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "UserMvc", action = "Create", id = UrlParameter.Optional }
            );
        }
    }
}
