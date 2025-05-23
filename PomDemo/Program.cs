using Microsoft.EntityFrameworkCore;
using PomDemo.Components;
using PomDemo.Data;
using PomDemo.Models;
using PomDemo.Services.Observers;

namespace PomDemo;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContextFactory<ServersDbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("ServerManagment"));
        });

        builder.Services
            .AddRazorComponents()
            .AddInteractiveServerComponents();

        builder.Services.AddScoped<TorontoOnlineServersStore>();

        builder.Services.AddTransient<IServersEfCoreRepository, ServersEfCoreRepository>();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseAntiforgery();
        app.MapStaticAssets();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}
