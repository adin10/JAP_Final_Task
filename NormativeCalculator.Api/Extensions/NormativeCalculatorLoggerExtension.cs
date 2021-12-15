using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NormativeCalculator.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormativeCalculator.Api.Extensions
{
    public static class NormativeCalculatorLoggerExtension
    {
        public static IServiceCollection LoggerService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NormativeCalculatorLoggerDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("Logger")));

            return services;
        }
    }
}
