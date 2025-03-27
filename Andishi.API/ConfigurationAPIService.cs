using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Core;
using Andishi.Infrastructure;

namespace Andishi.API
{
    public static class ConfigurationAPIService
    {
        public static IServiceCollection AllConfigurations(this IServiceCollection services, 
        IConfiguration configuration)   
        {
            services.AddInfrastructure().AddCore(configuration);
            return services;
        }
    }
}