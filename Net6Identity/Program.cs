using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Net6Identity.Models.Context;

var builder = WebApplication.CreateBuilder(args);

//MVC dahil etme
builder.Services.AddControllersWithViews();

//ConnectionString
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

//AddIdentity
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

//Custom Password Configuration
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
});

builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = new PathString("/Account/SignIn");
    x.AccessDeniedPath = new PathString("/Account/SignIn");
    x.Cookie = new CookieBuilder()
    {
        Name = "Yzl3156Cerez"
    };
    x.SlidingExpiration = true;
    x.ExpireTimeSpan = TimeSpan.FromMinutes(1);
});


//Pipeline

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // app.UseExceptionHandler("/Error");
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.UseRouting();

//app.MapDefaultControllerRoute();//controller=home/action=index/id?
app.UseAuthentication();
app.UseAuthorization();


app.UseEndpoints(x =>
{
    x.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{Controller=Home}/{Action=Index}/{id?}"
    );
    x.MapControllerRoute(
        name: "default",
        pattern: "{Controller=Home}/{Action=Index}/{id?}"
    );
});

//yetkilendirme
//giriş işlemi
app.Run();
