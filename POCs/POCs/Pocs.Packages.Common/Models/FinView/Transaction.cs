using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Pocs.Packages.Common.Models.FinView
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; } = String.Empty;
        public string? Commentary { get; set; }
        public double Value { get; set; }
        public int CategoryId { get; set; }
        public TransactionCategory Category { get; set; } = new TransactionCategory() { Id = 1001, Name = "Others"};
        public int ResponsableId { get; set; }
        public User Responsable { get; set; } = new User();
    }
}
