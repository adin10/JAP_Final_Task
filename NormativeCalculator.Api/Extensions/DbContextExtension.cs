using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NormativeCalculator.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NormativeCalculator.Api.Extensions
{
    public static class DbContextExtension
    {
        public static void DbContextService(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<NCDbContext>(x =>
            {
                x.UseSqlServer(config.GetConnectionString("DB"));
                x.LogTo(x => Debug.Print(x));
            });

        }
    }
}
