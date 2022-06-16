namespace POC_LambdaAndDelegate.Models.Responses
{
    public class RepositoryResponses
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public RepositoryResponses(bool status, string message)
        {
            Success = status;
            Message = message;
        }
    }
}