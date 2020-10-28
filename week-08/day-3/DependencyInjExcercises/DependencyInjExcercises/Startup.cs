using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjExcercises.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DependencyInjExcercises
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient<ConsoleLoggerMiddleware>();
            services.AddTransient<Printer>();
            services.AddTransient<IColor, RedColor>();
            services.AddTransient<IColor, GreenColor>();
            //services.AddTransient<IColor, BlueColor>();
            services.AddTransient<UtilityService>();
            services.AddTransient<MyOtherMiddleware>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMyConventionalMiddleware(); //Middleware A
            app.UseMiddleware<MyOtherMiddleware>(); //Middleware B

            app.UseMiddleware<ConsoleLoggerMiddleware>();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
