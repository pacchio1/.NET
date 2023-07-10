using Core_EF_codeFirst.Models;
using Microsoft.Identity.Client.Extensions.Msal;

namespace Core_EF_codeFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Storage27Context>();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.MapControllerRoute(
                name: "default", pattern:"{Controller=Categories}/{action=Index}/{id?}");
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}