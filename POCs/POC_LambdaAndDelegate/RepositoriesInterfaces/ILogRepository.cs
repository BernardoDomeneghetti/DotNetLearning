using POC_LambdaAndDelegate.Models;
using POC_LambdaAndDelegate.Models.Responses;

namespace POC_LambdaAndDelegate.RepositoriesInterfaces
{
    public interface ILogRepository
    {
        RepositoryResponses Append(DecriptedAction descriptedAction);
    }
}