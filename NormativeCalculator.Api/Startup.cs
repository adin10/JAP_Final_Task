using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Infrastructure.Mappers;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NormativeCalculator.Api.Extensions;

namespace NormativeCalculator.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
       
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.ApplicationServices(Configuration);
            //Database configuration
            //services.AddDbContext<NCDbContext>(x =>
            //{
            //    x.UseSqlServer(Configuration.GetConnectionString("DB"));
            //    x.LogTo(x => Debug.Print(x));
            //});

            //// Enable CORS     
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("EnableCORS", builder =>
            //    {
            //        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build();
            //    });
            //});

            ////Services
            //services.AddScoped<IIngredientService, IngredientService>();
            //services.AddScoped<IRecipeCategoryService, RecipeCategoryService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IRecipeService, RecipeService>();
            //services.AddScoped<IIngredientRecipeService, IngredientRecipeService>();

            ////IDENTITY
            //services.AddIdentity<IdentityUser<int>, IdentityRole<int>>()
            //    .AddEntityFrameworkStores<NCDbContext>().
            //    AddDefaultTokenProviders();


            ////Authentication
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //    // JWT BEARER
            //    .AddJwtBearer(options =>
            //    {
            //        options.SaveToken = true;
            //        options.RequireHttpsMetadata = false;
            //        options.TokenValidationParameters = new TokenValidationParameters()
            //        {
            //            ValidateIssuer = true,
            //            ValidateAudience = true,
            //            ValidAudience = Configuration["JWT:ValidAudience"],
            //            ValidIssuer = Configuration["JWT:ValidIssuer"],
            //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
            //        };
            //    });


            //services.Configure<PasswordHasherOptions>(x =>
            //{
            //    // za hashiranje passworda
            //    x.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3; // V3 -> SHA256, V2 -> SHA128
            //    x.IterationCount = 10000;
            //});

            //services.AddControllers().AddNewtonsoftJson(options =>
            //{
            //    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //});

            ////SWAGGER
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "NormativeCalculator.Api", Version = "v1" });
            //    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            //    {
            //        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
            //          Enter 'Bearer' [space] and then your token in the text input below.
            //          \r\n\r\nExample: 'Bearer 12345abcdef'",
            //        Name = "Authorization",
            //        In = ParameterLocation.Header,
            //        Type = SecuritySchemeType.ApiKey,
            //        Scheme = "Bearer"
            //    });

            //    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            //    {
            //        {new OpenApiSecurityScheme(){
            //        Reference = new OpenApiReference()
            //        {
            //            Id = "Bearer",
            //            Type = ReferenceType.SecurityScheme
            //        }
            //        }, new List<string>() }
            //    });
            //});


            ////MAPPER
            //services.AddAutoMapper(typeof(Mapper));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NormativeCalculator.Api v1"));
            }
            app.UseCors("EnableCORS");


            app.UseHttpsRedirection();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
