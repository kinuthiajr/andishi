using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Andishi.Core.Options;


namespace Andishi.Infrastructure
{
    public static class ConfigureInfrastructureService
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<AndishiDbContext>((provider, option) =>
            option.UseNpgsql(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>()
            .Value.dbString));

            return services;
        }
    }
}