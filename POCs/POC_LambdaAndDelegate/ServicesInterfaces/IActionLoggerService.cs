using Microsoft.AspNetCore.Mvc;
using POC_LambdaAndDelegate.Models;

namespace POC_LambdaAndDelegate.ServicesInterfaces
{
    public interface IActionLoggerService
    {
        delegate TResponse ActionToLog<TParam, TResponse> (TParam? par);

        TResponse ExecuteLoggedDelegate<TParam, TResponse> (ActionToLog<TParam, TResponse> action, TParam par);
        TResponse ExecuteLoggedFunc<TParam, TResponse>(Func<TParam, TResponse> action, TParam par);
    }
}
