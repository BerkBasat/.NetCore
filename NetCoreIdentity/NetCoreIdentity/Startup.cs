using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreIdentity.Models.Context;
using NetCoreIdentity.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIdentity
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            //MVC dahil edildi.
            services.AddControllersWithViews();
            //Context dahil edildi.
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer("connectionstring"));

            //Appuser ve rol dahil edildi.
            services.AddIdentity<AppUser, IdentityRole>(x=>{
                x.Password.RequireDigit = false;
                x.Password.RequireLowercase = false;
                x.Password.RequireUppercase = false;
                x.Password.RequiredLength = 6;
                x.Password.RequireNonAlphanumeric = false;

            }).AddEntityFrameworkStores<AppDbContext>();
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
