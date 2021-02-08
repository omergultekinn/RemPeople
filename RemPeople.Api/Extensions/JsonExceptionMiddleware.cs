using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using RemPeople.Api.Models;

namespace RemPeople.Api.Extensions
{
    /// <summary>
    /// Bütün hataları jsona çeviren bir exception handling.
    /// Development ve ya diğer ortamlara göre özel mesajlar basabiliyoruz.
    /// </summary>
    public sealed class JsonExceptionMiddleware
    {
        public const string DefaultErrorMessage = "A server error occurred.";

        private readonly IWebHostEnvironment _env;
        private readonly JsonSerializer _serializer;

        public JsonExceptionMiddleware(IWebHostEnvironment env)
        {
            _env = env;

            _serializer = new JsonSerializer();
            _serializer.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var ex = context.Features.Get<IExceptionHandlerFeature>()?.Error;
            if (ex == null) return;

            var error = BuildError(ex, _env);

            using (var writer = new StreamWriter(context.Response.Body))
            {
                _serializer.Serialize(writer, error);
                await writer.FlushAsync().ConfigureAwait(false);
            }
        }

        private static ApiError BuildError(Exception ex, IWebHostEnvironment env)
        {
            var error = new ApiError();

            if (env.IsDevelopment())
            {
                error.Message = ex.Message;
                error.Detail = ex.StackTrace;
            }
            else
            {
                error.Message = DefaultErrorMessage;
                error.Detail = ex.Message;
            }

            return error;
        }
    }
}
