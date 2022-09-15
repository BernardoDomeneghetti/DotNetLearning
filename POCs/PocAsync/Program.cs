using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PocAsyncDll.Worker.Extensions;

namespace PocAsync
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
        public static IServiceProvider? ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.SetPocAsyncServices();
                    services.AddTransient<MainForm>();
                });
        }
    }
}
