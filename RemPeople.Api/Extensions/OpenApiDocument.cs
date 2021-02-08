using Microsoft.Extensions.DependencyInjection;
using NSwag.Generation.Processors;

namespace RemPeople.Api.Extensions
{
    public static class OpenApiDocument
    {
        /// <summary>
        /// swagger document başlık bilgileri
        /// </summary>
        /// <param name="services"></param>
        public static void AddCustomOpenApiDocument(this IServiceCollection services)
        {
            services.AddOpenApiDocument(options =>
            {
                options.Version = "1.0";
                options.DocumentName = "v1.0";
                options.PostProcess = document =>
                {
                    document.Info.Version = "v1.0";
                    document.Info.Title = "RemPeople Salary Calculator API";
                    document.Info.Description = "First version of salary calculator";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Rem People",
                        Email = "omer.gultekinn@hotmail.com",
                        Url = "https://www.rempeople.com",
                    };
                };
                options.OperationProcessors.Add(new ApiVersionProcessor { IncludedVersions = new[] { "1.0" } });
            });

            services.AddOpenApiDocument(options =>
            {
                options.Version = "1.1";
                options.DocumentName = "v1.1";
                options.PostProcess = document =>
                {
                    document.Info.Version = "v1.1";
                    document.Info.Title = "RemPeople Salary Calculator API";
                    document.Info.Description = "version 1.1 of calculator";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Rem People",
                        Email = "omer.gultekinn@hotmail.com",
                        Url = "https://www.rempeople.com",
                    };
                };
                options.OperationProcessors.Add(new ApiVersionProcessor { IncludedVersions = new[] { "1.1" } });
            });
        }
    }
}
