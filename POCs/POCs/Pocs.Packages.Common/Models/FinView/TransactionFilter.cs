namespace Pocs.Packages.Common.Models.FinView
{
    public class TransactionFilter
    {
        public int Id { get; set; }
        public int ResponsableId { get; set; }
        public DateOnly SinceDate { get; set; }
        public DateOnly UntilDate { get; set; }
    }
}
