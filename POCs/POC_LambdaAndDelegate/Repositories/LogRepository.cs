using POC_LambdaAndDelegate.Models;
using POC_LambdaAndDelegate.Models.Responses;
using POC_LambdaAndDelegate.RepositoriesInterfaces;

namespace POC_LambdaAndDelegate.Repositories
{
    public class LogRepository : ILogRepository
    {
        public RepositoryResponses Append(DecriptedAction descriptedAction)
        {
            Console.WriteLine(
                @$"
                LoggedAction: 
                    Class: {descriptedAction.ActionClassParent},
                    Action: {descriptedAction.ActionName},
                    Action status: {descriptedAction.Status}
                "
            );

            return new RepositoryResponses(success: true, message:"Everything is Ok");
            //throw new NotImplementedException();
        }
    }
}
