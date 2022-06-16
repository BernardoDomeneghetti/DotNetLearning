using Microsoft.AspNetCore.Mvc;
using POC_LambdaAndDelegate.Exceptions;
using POC_LambdaAndDelegate.Models;
using POC_LambdaAndDelegate.RepositoriesInterfaces;
using POC_LambdaAndDelegate.ServicesInterfaces;
using static POC_LambdaAndDelegate.ServicesInterfaces.IActionLoggerService;

namespace POC_LambdaAndDelegate.Services
{
    internal class ActionLoggerService : IActionLoggerService
    {
        private readonly ILogRepository _LogRepository;

        public ActionLoggerService(ILogRepository logRepository_)
        {
            _LogRepository = logRepository_;
        }

        public IActionResult ExecuteLoggedAction<T>(ActionToLog<T> action, ActionParameter<T> par)
        {
            try
            {
                var response = action(par);
                LogSuccess(action);
                return response;
            }
            catch
            {
                LogFail(action);
                throw;
            }
        }

        private void LogFail<T>(ActionToLog<T> action)
        {
            AppendLog(
                new DecriptedAction(
                    status: ActionStatusEnum.Failure,
                    actionName: action.Method.Name,
                    actionClassParent: action.GetType().Name
                )
            );
        }

        private void LogSuccess<T>(ActionToLog<T> action)
        {
            AppendLog(
                new DecriptedAction(
                    status: ActionStatusEnum.Success,
                    actionName: action.Method.Name,
                    actionClassParent: action.GetType().Name
                )
            );
        }

        private void AppendLog(DecriptedAction descriptedAction)
        {
            try
            {
                var logResponse = _LogRepository.Append(descriptedAction);

                if (!logResponse.Success)
                    throw new LoggingOperationFailedException(descriptedAction);
            }
            catch (Exception e)
            {
                throw new LoggingOperationFailedException(descriptedAction, e.Message);
            }
        }
    }
}