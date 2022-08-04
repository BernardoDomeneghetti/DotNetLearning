namespace POC_LambdaAndDelegate.Models.Responses
{
    public class RepositoryResponses
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public RepositoryResponses(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}