using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Middleware
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public SimpleMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<SimpleMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("[Middleware - BEFORE]");            
            context.Response.Headers.CacheControl = "no-store";
            context.Response.Headers.Pragma = "no-cache";
            context.Response.Headers.Expires = "0";
            await _next(context);
            _logger.LogInformation("[Middleware - AFTER]");
        }
    }

    public static class SimpleMiddlewareExtensions
    {
        public static IApplicationBuilder UseSampleMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SimpleMiddleware>();
        }
    }
}