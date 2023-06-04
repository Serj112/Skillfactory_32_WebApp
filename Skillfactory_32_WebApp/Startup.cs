/*
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Skillfactory_32_WebApp.Models;
using Skillfactory_32_WebApp.Controllers;
using Skillfactory_32_WebApp.Models.Db;

public class Startup
{
    static IWebHostEnvironment _env;
    public IConfiguration _configuration;

    public Startup(IWebHostEnvironment env, IConfiguration configuration)
    {
        _env = env;
        _configuration = configuration;
    }

    // Метод вызывается средой ASP.NET.
    // Используйте его для подключения сервисов приложения
    // Документация:  https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IUserInfoRepository, UserInfoRepository>();

        string connection = _configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<BlogContext>(options => options.UseSqlServer(connection));
        services.AddControllersWithViews();
        // регистрация сервиса репозитория для взаимодействия с базой данных
        services.AddSingleton<IBlogRepository, BlogRepository>();
    }

    // Метод вызывается средой ASP.NET.
    // Используйте его для настройки конвейера запросов
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });

        app.UseMiddleware<LoggingMiddleware>();
    }
}*/