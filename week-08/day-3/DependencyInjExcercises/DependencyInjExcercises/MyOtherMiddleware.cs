using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DependencyInjExcercises
{
    public class MyOtherMiddleware : IMiddleware
    {
        public MyOtherMiddleware()
        {
            Console.WriteLine("Hello from Conv. middlevare B");
        }
        public Task InvokeAsync(HttpContext httpContext, RequestDelegate next)
        {
            return next(httpContext);
        }
    }
}
