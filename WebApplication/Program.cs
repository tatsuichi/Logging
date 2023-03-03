using NLog;
using NLog.Web;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
            logger.Debug("init main");
            try
            {
                var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

                // Add services to the container.

                builder.Services.AddControllers();

                // NLog: Setup NLog for Dependency injection
                builder.Logging.ClearProviders();
                builder.Host.UseNLog();

                var app = builder.Build();

                // Configure the HTTP request pipeline.

                app.UseAuthorization();


                app.MapControllers();

                app.Run();
            }
            catch (Exception exception)
            {
                // NLog: catch setup errors
                logger.Error(exception, "Stopped program because of exception");
                throw;
            }
            finally
            {
                // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                NLog.LogManager.Shutdown();
            }
        }
    }
}