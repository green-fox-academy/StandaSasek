using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace DependencyInjExcercises
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyConventionalMiddleware
    {
        private readonly RequestDelegate _next;

        public MyConventionalMiddleware(RequestDelegate next)
        {
            _next = next;
            Console.WriteLine("Hello from Conv. middlevare A");
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyConventionalMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyConventionalMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyConventionalMiddleware>();
        }
    }
}
