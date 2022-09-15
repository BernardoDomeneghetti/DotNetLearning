using Microsoft.Extensions.DependencyInjection;
using PocAsyncDll.Worker.Interfaces;

namespace PocAsyncDll.Worker.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void SetPocAsyncServices(this IServiceCollection services)
        {
            services.AddScoped<IDocumentWorker, DocumentWorker>();
        }
    }
}