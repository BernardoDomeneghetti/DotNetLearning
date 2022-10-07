namespace Pocs.Packages.Common.Models.FinView
{
    public class TransactionFilter
    {
        public TransactionFilter(int id, int responsableId, DateTime sinceDate, DateTime untilDate)
        {
            Id = id;
            ResponsableId = responsableId;
            SinceDate = sinceDate;
            UntilDate = untilDate;
        }

        public int Id { get; set; }
        public int ResponsableId { get; set; }
        public DateTime SinceDate { get; set; }
        public DateTime UntilDate { get; set; }
    }
}
