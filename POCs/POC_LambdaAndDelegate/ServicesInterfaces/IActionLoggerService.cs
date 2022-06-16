using Microsoft.AspNetCore.Mvc;
using POC_LambdaAndDelegate.Models;

namespace POC_LambdaAndDelegate.ServicesInterfaces
{
    public interface IActionLoggerService
    {
        delegate IActionResult ActionToLog<T> (ActionParameter<T> par);
        IActionResult ExecuteLoggedAction<T> (ActionToLog<T> action, ActionParameter<T> par);
    }
}
