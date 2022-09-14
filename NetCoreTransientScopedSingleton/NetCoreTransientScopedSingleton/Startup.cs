using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreTransientScopedSingleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTransientScopedSingleton
{
    public class Startup
    {
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //ITransient
            services.AddTransient<ITransient, OperationService>();
            //IScoped
            services.AddScoped<IScoped, OperationService>();
            //ISingleton
            services.AddSingleton<ISingleton, OperationService>();
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
