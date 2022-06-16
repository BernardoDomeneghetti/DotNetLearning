using Microsoft.AspNetCore.Mvc;
using POC_LambdasAndDelegates.Models;

namespace POC_LambdasAndDelegates.ServicesInterfaces
{
    public interface IActionLoggerService
    {
        delegate IActionResult ActionToLog<T> (ActionParameter<T> par);
        IActionResult ExecuteLoggedAction<T> (ActionToLog<T> action, ActionParameter<T> par);
    }
}
