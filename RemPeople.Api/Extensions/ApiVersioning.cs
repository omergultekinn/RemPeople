using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace RemPeople.Api.Extensions
{
    /// <summary>
    /// api versioning
    /// </summary>
    public static class ApiVersioning
    {
        /// <summary>
        /// Cuatom versioning infoes
        /// </summary>
        /// <param name="services"></param>
        public static void AddCustomApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                //url segment => {version}
                options.AssumeDefaultVersionWhenUnspecified = true; //default => false;
                options.DefaultApiVersion = new ApiVersion(1, 0); //v1.0 == v1
                options.ReportApiVersions = true;

            });
        }

        /// <summary>
        /// Version format tanımlaması
        /// </summary>
        /// <param name="services"></param>
        public static void AddCustomVersionedApiExplorer(this IServiceCollection services)
        {
            services.AddVersionedApiExplorer(options => {
                options.SubstituteApiVersionInUrl = true;
                options.SubstitutionFormat = "VVVV";
            });
        }
    }
}
