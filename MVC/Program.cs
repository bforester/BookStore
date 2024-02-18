namespace MVC;

public class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        var app = builder.Build();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=home}/{action=index1}/{id?}");

        app.Run();
    }
}