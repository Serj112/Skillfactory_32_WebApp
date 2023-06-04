using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Skillfactory_32_WebApp.Models;
using Skillfactory_32_WebApp.Controllers;
using Skillfactory_32_WebApp.Models.Db;

namespace Skillfactory_32_WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            string connection = builder.Configuration.GetConnectionString("DefaultConnection");
            string logConnection = builder.Configuration.GetConnectionString("LogConnection");
            Console.WriteLine(connection);

            builder.Services.AddDbContext<BlogContext>(options => options.UseSqlServer(connection));
            builder.Services.AddTransient<IBlogRepository, BlogRepository>();

            builder.Services.AddDbContext<RequestContext>(options => options.UseSqlServer(logConnection));
            builder.Services.AddTransient<IRequestRepository, RequestRepository>();
            //builder.Services.AddTransient<RequestRepository>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMiddleware<LoggingMiddleware>();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "Users",
                pattern: "{controller=Users}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "Feedback",
                pattern: "{controller=Feedback}/{action=Add}/{id?}");

            app.MapControllerRoute(
                name: "Logs",
                pattern: "{controller=Logs}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

/*var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
*/