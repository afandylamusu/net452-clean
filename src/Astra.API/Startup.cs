using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin;
using Swashbuckle.Application;
using System.Reflection;
using System.Web.Http;
using System;

[assembly: OwinStartup(typeof(Astra.API.Startup))]

namespace Astra.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();


            // Run other optional steps, like registering filters,
            RegisterServices(builder);

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();

            var webApiConfiguration = ConfigureWebApi(container);

            // Use the extension method provided by the WebApi.Owin library:
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(webApiConfiguration);
            app.UseWebApi(webApiConfiguration);


            RouteMVCConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
        }

        private void RegisterServices(ContainerBuilder builder)
        {
            
        }

        private HttpConfiguration ConfigureWebApi(IContainer container)
        {
           
            var config = new HttpConfiguration();

            // per-controller-type services, etc., then set the dependency resolver
            // to be Autofac.
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            // Register the Autofac middleware FIRST, then the Autofac Web API middleware,
            // and finally the standard Web API middleware.


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
