using Astra.Infrastructure;
using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.Owin;
using Owin;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: OwinStartup(typeof(Astra.Backend.Startup))]

namespace Astra.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            EngineContext.Initialize(false);

            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
