using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");





            routes.MapMvcAttributeRoutes();                                                                                                                                           





            ////***************Custom Route Example First Example*****************
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "Movies/released/{year}/{month}", //Path and Parameter and how will entered
            //    new { Controller = "Movies", action = "ByReleaseDate" }, // Default Route Action for Controller Movies
            //    new { year = @"\d{4}", month = @"\d{2}" }); // Define how digits have any parameter

            ////******************************************************

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
