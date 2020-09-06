using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Movies.Models;
using Movies.Models.Entities;

namespace Movies
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            services.AddDbContext<MyContext>(o => o.UseSqlServer(connString));

            // Add support for controllers and views
            services.AddControllersWithViews();
            services.AddTransient<MoviesService>();

        }

        public void Configure(IApplicationBuilder app,
            IWebHostEnvironment env)
        {
            // Are we in development?
            if (env.IsDevelopment())
            {
                // Then show detailed error messages
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //app.UseEndpoints(e => e.MapControllers());
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}");
            });

            app.UseStaticFiles();
        }

    }
}
