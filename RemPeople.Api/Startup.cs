using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RemPeople.Api.Extensions;
using RemPeople.Business;
using RemPeople.Business.Implementations;
using RemPeople.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemPeople.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region OpenApi configuration

            services.AddCustomApiVersioning();

            services.AddCustomVersionedApiExplorer();

            services.AddCustomOpenApiDocument();
            #endregion OpenApi configuration
            
            services.AddControllersWithViews()
               .AddNewtonsoftJson(options =>
               options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddTransient<ISalaryCalculator, SalaryCalculator>();
            services.AddTransient<ICalculateServiceCreater, CalculateServiceCreater>();
            services.AddTransient<ISalaryCalculator, SalaryCalculator>();
            services.AddTransient<ISalaryRepo, SalaryRepo>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region OpenApi configurations
            app.UseOpenApi(options =>
            {
                options.DocumentName = "v1.0";
            });
            app.UseSwaggerUi3(c =>
            {
                c.DocumentTitle = "RemPeople Salary Calculator Api";
            });
            #endregion OpenApi configurations

            // Serialize all exceptions to JSON
            var jsonExceptionMiddleware = new JsonExceptionMiddleware(
                app.ApplicationServices.GetRequiredService<IWebHostEnvironment>());
            app.UseExceptionHandler(new ExceptionHandlerOptions { ExceptionHandler = jsonExceptionMiddleware.Invoke });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
