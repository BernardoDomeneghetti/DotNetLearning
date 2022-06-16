namespace POC_LambdaAndDelegate.Models
{
    public class ActionParameter<T> : BaseModel
    {
        public T Content { get; set; }

        public ActionParameter(T content)
        {
            Content = content;
        }
    }
}