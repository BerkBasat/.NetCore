using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreCodeFirst.Models.Context;
using NetCoreCodeFirst.Models.Repository;
using NetCoreCodeFirst.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCodeFirst
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //Dbcontext
            services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer("connectionstring"));

            //Transient
            services.AddTransient<ICategoryService, CategoryService>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(x =>
            {
                x.MapControllerRoute(name: "default", pattern: "{Controller=Home}/{Action=Index}/{id?}");
            });
        }
    }
}
