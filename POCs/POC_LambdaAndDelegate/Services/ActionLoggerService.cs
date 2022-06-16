using Microsoft.AspNetCore.Mvc;
using POC_LambdasAndDelegates.Models;
using POC_LambdasAndDelegates.RepositoriesInterfaces;
using POC_LambdasAndDelegates.ServicesInterfaces;
using static POC_LambdasAndDelegates.ServicesInterfaces.IActionLoggerService;

namespace POC_LambdasAndDelegates.Services
{
    internal class ActionLoggerService : IActionLoggerService
    {
        private readonly ILogRepository LogRepository_;

        public ActionLoggerService(ILogRepository logRepository_)
        {
            LogRepository_ = logRepository_;
        }

        public IActionResult ExecuteLoggedAction<T>(ActionToLog<T> action, ActionParameter<T> par)
        {
            try
            {
                return action(par);

            }
            catch
            {
                return null;
            }
        }
    }
}
