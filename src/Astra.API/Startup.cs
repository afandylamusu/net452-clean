using Microsoft.Owin;
using Owin;
using Swashbuckle.Application;
using System.Web.Http;

[assembly: OwinStartup(typeof(Astra.API.Startup))]

namespace Astra.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var webApiConfiguration = ConfigureWebApi();

            // Use the extension method provided by the WebApi.Owin library:
            app.UseWebApi(webApiConfiguration);

            RouteMVCConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
        }


        private HttpConfiguration ConfigureWebApi()
        {
            var config = new HttpConfiguration();
            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "WebAPI");
                c.IncludeXmlComments(GetXmlCommentsPath());
            }).EnableSwaggerUi();

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            return config;
        }

        private string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\bin\Astra.API.xml",
                        System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
