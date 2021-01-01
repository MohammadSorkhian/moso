using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //// This is the first midleware that with the benfit of logger.LogInformation generate some loogs and shows use the first logger is executed as middleware receives a request and the latter one is executed when the midleware receievs a response
            //app.Use(async (context, next) =>
            //{
            //    logger.LogInformation("MW1 Request");
            //    await next();
            //    logger.LogInformation("MW1 Response");

            //});      


            //app.Use(async (context, next) =>
            //{
            //    logger.LogInformation("MW2 Request");
            //    await next();
            //    logger.LogInformation("MW2 Response");
            //});


            //// If we want to use a costomized default file(e.g html file) we need to specify it as default
            //DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            //defaultFilesOptions.DefaultFileNames.Clear();
            //defaultFilesOptions.DefaultFileNames.Add("moso.html");


            // In order to be able to use the wwwroot/default.html we need to add this midleware. This midleware should preceed the UseStaticFiles() midleware
            //app.UseDefaultFiles();


            // Helps us to use static files that have been located in the wwwroot folder
            app.UseStaticFiles();


            app.UseMvcWithDefaultRoute();


            app.Run(async (context) =>
            {
                //throw new Exception("there is an error here");
                await context.Response.WriteAsync("Hello Mohammad 2nd!! ");
                //logger.LogInformation("MWterminal Response");
            });

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
