using Microsoft.Extensions.DependencyInjection;
using POC_LambdaAndDelegate.Repositories;
using POC_LambdaAndDelegate.RepositoriesInterfaces;
using POC_LambdaAndDelegate.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_LambdaAndDelegate.Config
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCodeLogger(this IServiceCollection services)
        {
            services.AddSingleton<IActionLoggerService, IActionLoggerService>();
            services.AddSingleton<ILogRepository, LogRepository>();
        }
    }
}
