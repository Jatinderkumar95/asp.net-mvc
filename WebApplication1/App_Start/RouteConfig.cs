using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // URl - appbasepath/trace.axd
            // axd is file extension for trace file.
            // <trace enabled="true" pageOutput="false"/>
            // this enables mapping of axd file.
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Practice", id = UrlParameter.Optional }
            );
        }
    }
}
