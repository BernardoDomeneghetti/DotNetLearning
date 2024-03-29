﻿using Microsoft.Extensions.Hosting;
using PocAsyncConsole;
using PocAsyncDll.Worker;
using PocAsyncDll.Worker.Extensions;

internal class Program
{
    private static void Main(string[] args)
    {
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;
        new MenuActions(new DocumentWorker()).ControlMenuAsync();
    }

    public static IServiceProvider? ServiceProvider { get; private set; }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.RegisterPocAsyncServicesAsSingleton();
            });
    }
}