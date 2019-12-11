using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blog.Business.Abstract;
using Blog.Business.Concrete;
using Blog.DataAccess.Abstract;
using Blog.DataAccess.Concrete.EntityFramework;
using Blog.WebUI.Extensions;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace Blog.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddBlogServices();

            //Classes
            services.AddScoped<IClassService, ClassManager>();


            //Mvc
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); // For the wwwroot folder

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "Content")),
                RequestPath = "/content"
            });

            app.UseMvc(routes =>
            {
                //Admin Default Route
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                //Admin/Class Route
                routes.MapRoute(
                    name: "areasClass",
                    template: "{area:exists}/{controller=Class}/{action=Index}/{id:int?}/{classId:int?}/{classTypeId:int?}");

                //Default Route
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            //app.UseMvcWithDefaultRoute();
        }
        //private void ConfigureRoutes(IRouteBuilder routeBuilder)
        //{
        //    routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        //}
    }
}
