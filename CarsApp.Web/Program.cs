using CarsApp.Web.Services;

namespace CarsApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<CarService>();

            var app = builder.Build();

            app.MapControllers();  

            app.Run();
        }
    }
}
