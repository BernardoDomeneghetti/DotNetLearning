using POC_LambdaAndDelegate.Models;
using POC_LambdaAndDelegate.Models.Responses;
using POC_LambdaAndDelegate.RepositoriesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_LambdaAndDelegate.Repositories
{
    internal class LogRepository : ILogRepository
    {
        public RepositoryResponses Append(DecriptedAction descriptedAction)
        {
            throw new NotImplementedException();
        }
    }
}
