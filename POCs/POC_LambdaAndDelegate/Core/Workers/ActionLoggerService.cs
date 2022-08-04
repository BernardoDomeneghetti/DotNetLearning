using Microsoft.AspNetCore.Mvc;
using POC_LambdaAndDelegate.Enums;
using POC_LambdaAndDelegate.Exceptions;
using POC_LambdaAndDelegate.Models;
using POC_LambdaAndDelegate.RepositoriesInterfaces;
using POC_LambdaAndDelegate.ServicesInterfaces;
using static POC_LambdaAndDelegate.ServicesInterfaces.IActionLoggerService;

namespace POC_LambdaAndDelegate.Core.Workers
{
    public class ActionLoggerService : IActionLoggerService
    {
        private readonly ILogRepository _LogRepository;

        public ActionLoggerService(ILogRepository logRepository_)
        {
            _LogRepository = logRepository_;
        }

        public TResponse ExecuteLoggedDelegate<TParam, TResponse>(ActionToLog<TParam, TResponse> action , TParam par)
        {
            try
            {
                var response = action(par);
                LogSuccessDelegate(action);
                return response;
            }
            catch
            {
                LogFailDelegate(action);
                throw;
            }
        }

        public TResponse ExecuteLoggedFunc<TParam, TResponse>(Func<TParam, TResponse> action, TParam par)
        {
            try
            {
                var response = action(par);
                LogSuccessLambdaFunc(action);
                return response;
            }
            catch
            {
                LogFailLambdaFunc(action);
                throw;
            }
        }

        private void LogFailDelegate <TParam, TResponse>(ActionToLog<TParam, TResponse> action)
        {
            AppendLog(
                new DecriptedAction(
                    status: ActionStatusEnum.Failure,
                    actionName: action.Method.Name,
                    actionClassParent: action.GetType().Name
                )
            );
        }

        private void LogFailLambdaFunc<TParam, TResponse>(Func<TParam, TResponse> action)
        {
            AppendLog(
                new DecriptedAction(
                    status: ActionStatusEnum.Failure,
                    actionName: action.Method.Name,
                    actionClassParent: action.GetType().Name
                )
            );
        }

        private void LogSuccessDelegate <TParam, TResponse>(ActionToLog<TParam, TResponse> action)
        {
            AppendLog(
                new DecriptedAction(
                    status: ActionStatusEnum.Success,
                    actionName: action.Method.Name,
                    actionClassParent: action.GetType().Name
                )
            );
        }

        private void LogSuccessLambdaFunc<TParam, TResponse>(Func<TParam, TResponse> action)
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