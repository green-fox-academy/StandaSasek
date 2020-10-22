using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjExcercises.Controllers;
using Microsoft.AspNetCore.Http;

namespace DependencyInjExcercises
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        private Printer MyPrinter { get; set; }
        private IColor MyColor { get; set; }
        public ConsoleLoggerMiddleware(Printer printer, IColor myColor)
        {
            MyPrinter = printer;
            MyColor = myColor;
        } 
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            MyPrinter.Log("I AM A PRINTER AND WILL GET YOUR HP");
            MyColor.PrintColor();
            return next(context);
        }
    }
}
