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
        public void ControlMenu()
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

                    case "6":
                        Exit();
                        break;

                    default:
                        Console.WriteLine("A opção digitada é inválida!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void Exit()
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

        private void ExecuteSync()
        {
            object? result = null;
            var progress = new Progress<DocumentModel>();
            var tasks = new List<Task>();

            Task.Factory.StartNew(() =>
            {
                result = _documentWorker.VerifyDocumentsSync(progress);
            });

            Task.Factory.StartNew(() =>
            {
                PrintLoading("Starting Syncronous verification", result);
            });

            Task.WhenAll(tasks);
        }

        private void PrintLoading(string startString, object? response)
        {
            Console.Clear();
            var count = 0;

            while (response == null)
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