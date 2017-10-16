using Astra.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Astra.Core.Configuration;
using Autofac;

namespace Astra.API.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 1;

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            
        }
    }
}