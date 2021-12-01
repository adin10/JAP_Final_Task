using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Infrastructure.Services;
using System.Diagnostics;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using NormativeCalculator.Database;

namespace NormativeCalculator.Api.Extensions
{
   public static class ServiceExtensions
    {
        public static void ApplicationServices(this  IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<IRecipeCategoryService, RecipeCategoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<ICalculatedService, CalculatedService>();
        }
    }
}
