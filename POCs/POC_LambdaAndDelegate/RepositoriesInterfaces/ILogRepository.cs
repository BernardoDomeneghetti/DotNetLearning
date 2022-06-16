using POC_LambdaAndDelegate.Models;
using POC_LambdaAndDelegate.Models.Responses;

namespace POC_LambdaAndDelegate.RepositoriesInterfaces
{
    internal interface ILogRepository
    {
        RepositoryResponses Append(DecriptedAction descriptedAction);
    }
}