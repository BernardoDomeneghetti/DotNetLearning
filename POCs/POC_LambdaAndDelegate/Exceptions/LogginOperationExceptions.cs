using POC_LambdaAndDelegate.Models;

namespace POC_LambdaAndDelegate.Exceptions
{
    internal class LoggingOperationFailedException : Exception
    {
        public LoggingOperationFailedException(DecriptedAction descriptedAction)
        {
            string message =
                @$"
                    The Logging operation failed during the action: {descriptedAction.ActionName}
                    Action declared in the class: {descriptedAction.ActionClassParent}
                    There was no exception message!
                ";
        }

        public LoggingOperationFailedException(DecriptedAction descriptedAction, string exceptionMessage)
        {
            string message =
                @$"
                    The Logging operation failed during the action: {descriptedAction.ActionName}
                    Action declared in the class: {descriptedAction.ActionClassParent}
                    The original exception message was: {exceptionMessage}
                ";
        }
    }
}