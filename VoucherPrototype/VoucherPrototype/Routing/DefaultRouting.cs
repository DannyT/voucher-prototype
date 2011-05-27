using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcTurbine.Routing;
using System.Web.Routing;
using System.Web.Mvc;

namespace VoucherPrototype.Routing
{
    public class DefaultRouting : IRouteRegistrator
    {
        public void Register(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
                );
        }
    }
}