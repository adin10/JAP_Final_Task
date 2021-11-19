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
using NormativeCalculator.Infrastructure.Mappers;
using Microsoft.Extensions.Configuration;
using NormativeCalculator.Database;

namespace NormativeCalculator.Api.Extensions
{
   public static class ServiceExtensions
    {
        public static void ApplicationServices(this  IServiceCollection services, IConfiguration config)
        {
            //Database configuration
            services.AddDbContext<NCDbContext>(x =>
            {
                x.UseSqlServer(config.GetConnectionString("DB"));
                x.LogTo(x => Debug.Print(x));
            });


            // Enable CORS     
            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build();
                });
            });

            //Services
            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<IRecipeCategoryService, RecipeCategoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IIngredientRecipeService, IngredientRecipeService>();

            //IDENTITY
            services.AddIdentity<IdentityUser<int>, IdentityRole<int>>()
                .AddEntityFrameworkStores<NCDbContext>().
                AddDefaultTokenProviders();


            //Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                // JWT BEARER
                .AddJwtBearer(options =>
                {
                    options.SaveToken = true;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidAudience = config["JWT:ValidAudience"],
                        ValidIssuer = config["JWT:ValidIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:Secret"]))
                    };
                });


            services.Configure<PasswordHasherOptions>(x =>
            {
                // password hashing
                x.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3; // V3 -> SHA256, V2 -> SHA128
                x.IterationCount = 10000;
            });

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            //SWAGGER
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NormativeCalculator.Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {new OpenApiSecurityScheme(){
                    Reference = new OpenApiReference()
                    {
                        Id = "Bearer",
                        Type = ReferenceType.SecurityScheme
                    }
                    }, new List<string>() }
                });
            });


            //MAPPER
            services.AddAutoMapper(typeof(Mapper));
           //return services;

        }
    }
}
