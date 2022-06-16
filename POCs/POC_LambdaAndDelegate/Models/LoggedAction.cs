namespace POC_LambdaAndDelegate.Models
{
    public class DecriptedAction : BaseModel
    {
        public ActionStatusEnum Status { get; set; }
        public string ActionName { get; set; }
        public string ActionClassParent { get; set; }

        public DecriptedAction(ActionStatusEnum status, string actionName, string actionClassParent)
        {
            Status = status;
            ActionName = actionName;
            ActionClassParent = actionClassParent;
        }
    }
}