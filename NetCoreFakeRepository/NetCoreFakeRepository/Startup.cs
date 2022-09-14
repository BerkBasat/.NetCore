using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreFakeRepository.Models.BaseRepository;
using NetCoreFakeRepository.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFakeRepository
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //services.AddTransient<>
            //services.AddScoped<>
            //services.AddSingleton<>

            services.AddTransient<IEmployeeRepository, EmployeeData>();

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
