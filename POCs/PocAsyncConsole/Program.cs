using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PocAsyncDll.Worker.Extensions;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;
        ControlMenu();
    }

    public static IServiceProvider? ServiceProvider { get; private set; }
    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => {
                services.RegisterPocAsyncServicesAsSingleton();
            });
    }

    private static void ExecuteSync()
    {
        Task.Factory.StartNew(() =>
        {

        });

        PrintLoading("Starting Syncronous verification", null);
    }

    private static void PrintLoading(string startString, object response)
    {
        Console.Clear();
        var count = 0;

        while (response == null)
        {
            if (count == 0)
            {
                Console.WriteLine(startString);
                Console.WriteLine("Exeecuting proccess");
            }
            count++;
            Thread.Sleep(1000);
            Console.Write(".");
            if (count >= 10)
            {
                Console.Clear();
                count = 0;
            }
        }
    }

    private static void ControlMenu()
    {
        var option = "";
        
        while (option != "6")
        {
            Console.Clear();
            Console.Write(
                "   1 - Sync Verify                 " +
                " \n   2 - Dumb Async Verify        " +
                " \n   3 - Async Parallel Verify    " +
                " \n   4 - Async Parallel Verify V2 " +
                " \n   5 - Cancell                  " +
                " \n   6 - Exit                     " +
                " \n Type the option number: "
            );

            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    ExecuteSync();
                    break;

                case "2":
                    Console.WriteLine("b");
                    break;

                case "3":
                    Console.WriteLine("c");
                    break;

                case "4":
                    Console.WriteLine("d");
                    break;

                case "5":
                    Console.WriteLine("e");
                    break;

                default:
                    Console.WriteLine("A opção digitada é inválida!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}