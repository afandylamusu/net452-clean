using System.Web.Mvc;
using System.Web.Routing;

namespace Astra.API
{
    internal class RouteMVCConfig
    {
        internal static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                "Default",                                              // Route name 
                "{controller}/{action}/{id}",                           // URL with parameters 
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );
        }
    }
}