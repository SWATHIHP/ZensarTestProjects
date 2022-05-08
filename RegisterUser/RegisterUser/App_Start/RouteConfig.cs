using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RegisterUser
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

          

            routes.MapRoute(
                "CountriesList",
                "UserMvc/Countries/List",
                new { controller = "UserMvc", action = "CountryList" }
            );

            routes.MapRoute(
              "StatesList",
              "UserMvc/States/List/{CountryCode}",
              new { controller = "UserMvc", action = "StateList", CountryCode = "" }
          );

            routes.MapRoute(
               "CitiesList",
               "UserMvc/Cities/List/{StateCode}",
               new { controller = "UserMvc", action = "CityList", StateCode = "" }
           );

            
            routes.MapRoute(
          "UserDetails",
          "Details/{Id}",
          new { controller = "UserMvc", action = "Details" ,Id = UrlParameter.Optional });
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
