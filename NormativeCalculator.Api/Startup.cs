using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NormativeCalculator.Api.Exceptions;
using NormativeCalculator.Api.Extensions;
using NormativeCalculator.Database;
using NormativeCalculator.Mapper;

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
            services.DbContextService(Configuration);
            services.CorsService(Configuration);
            services.ApplicationServices(Configuration);
            services.IdentityServices(Configuration);
            services.SwaggerService(Configuration);
            services.LoggerService(Configuration);

            services.AddAutoMapper(typeof(NormativeCalculatorProfile));         
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<NCDbContext>();
                context.Database.Migrate();
            }

            if (env.IsDevelopment())
            {

                app.UseMiddleware<ExceptionMiddleware>();
                //app.UseDeveloperExceptionPage();
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
