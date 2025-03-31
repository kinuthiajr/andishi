using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Andishi.Core.Options;
using Andishi.Core.Interfaces;
using Andishi.Infrastructure.Repository;
using Andishi.Application.Interfaces;
using Andishi.Application.Services.ArticleService;
using Andishi.Application.Services.ResponseService;


namespace Andishi.Infrastructure
{
    public static class ConfigureInfrastructureService
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<AndishiDbContext>((provider, option) =>
            option.UseNpgsql(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>()
            .Value.dbString));

            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<IResponseRepository, ResponseRepository>();
            services.AddScoped<IResponseService, ResponseService>();
            return services;
        }
    }
}