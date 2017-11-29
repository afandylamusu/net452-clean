using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astra.Core.Configuration;
using Autofac;

namespace Astra.WebFramework.Mvc
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 0;

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            
        }
    }
}
