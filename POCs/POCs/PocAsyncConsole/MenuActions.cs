using PocAsyncDll.Common.Model;
using PocAsyncDll.Worker.Interfaces;

namespace PocAsyncConsole
{
    internal class MenuActions
    {
        private readonly IDocumentWorker _documentWorker;

        public MenuActions(IDocumentWorker documentWorker)
        {
            _documentWorker = documentWorker;
        }

        public async Task ControlMenuAsync()
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
                Task task;
                switch (option)
                {
                    case "1":
                        ExecuteSync().Wait();
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

                    case "6":
                        Exit();
                        break;

                    default:
                        Console.WriteLine("A opção digitada é inválida!");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();

                Console.WriteLine("The documents were verified, do you want to:");
                Console.WriteLine("1 - Exit");
                Console.WriteLine("Anything - Continue");
                Console.WriteLine("Type the wanted option: ");

                var option2 = Console.ReadLine();

                if (option2 == "1")
                {
                    option = "6";
                    Exit();
                }
                    
            }
        }

        private static void Exit()
        {
            Console.Clear();
            Console.Write("Shutting off");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("  Bye");
            Thread.Sleep(1000);
        }

        private async Task ExecuteSync()
        {
            object? result = null;
            var progress = new Progress<DocumentModel>();
            var cancellationToken = new CancellationTokenSource();

            var taskVerifyDocuments = Task.Factory.StartNew(() =>
            {
                result = _documentWorker.VerifyDocumentsSync(progress);
            });

            var loadingPrinter = Task.Factory.StartNew(() =>
            {
                PrintLoading("Starting Syncronous verification", cancellationToken.Token);
            });

            await taskVerifyDocuments;
            cancellationToken.Cancel();
        }

        private static void PrintLoading(string startString, CancellationToken cancellationToken)
        {
            Console.Clear();
            var count = 0;

            while (!cancellationToken.IsCancellationRequested)
            {
                if (count == 0)
                {
                    Console.WriteLine(startString);
                    Console.WriteLine("Executing proccess");
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
    }
}