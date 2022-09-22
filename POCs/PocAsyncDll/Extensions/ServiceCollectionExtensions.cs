using Microsoft.Extensions.DependencyInjection;
using PocAsyncDll.Worker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocAsyncDll.Worker.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterPocAsyncServicesAsSingleton(this IServiceCollection services)
        {
            services.AddSingleton<IDocumentWorker, DocumentWorker>();
        }
    }
}
