using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using IdentityServer3.Core.Configuration;

[assembly: OwinStartup(typeof(Astra.Identity.Startup))]

namespace Astra.Identity
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigIdentityServer(app);
        }

        private void ConfigIdentityServer(IAppBuilder app)
        {
            var options = new IdentityServerOptions
            {
                Factory = new IdentityServerServiceFactory()
                            .UseInMemoryClients(Clients.Get())
                            .UseInMemoryScopes(Scopes.Get())
                            .UseInMemoryUsers(Users.Get()),

                RequireSsl = false
            };

            app.UseIdentityServer(options);
        }
    }
}
