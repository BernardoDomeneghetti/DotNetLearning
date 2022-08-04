using Microsoft.AspNetCore.Mvc;
using POC_LambdaAndDelegate.Core.Workers;
using POC_LambdaAndDelegate.Models;
using POC_LambdaAndDelegate.Repositories;
using POC_LambdaAndDelegate.ServicesInterfaces;
using static POC_LambdaAndDelegate.ServicesInterfaces.IActionLoggerService;

namespace POCs.SandBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Sample().execute();
            
        }

        public class Sample
        {
            private IActionLoggerService _logger;
            private ActionToLog<string, string> _actionToLog;

            public Sample()
            {
                _logger = new ActionLoggerService(new LogRepository());
            }

            public string SampleMethodFunc(string text)
            {
                Console.WriteLine(text);
                return text;
            }

            public string SampleMethodDelegate(string text)
            {
                Console.WriteLine(text);
                return text;
            }

            public void execute()
            {
                _actionToLog = SampleMethodDelegate;

                //_logger.ExecuteLoggedDelegate(_actionToLog, new ActionParameter<string>("Teste delegate"));
                _logger.ExecuteLoggedFunc<string, string>(SampleMethodFunc, "Teste func");
            }
        }
    }
}
