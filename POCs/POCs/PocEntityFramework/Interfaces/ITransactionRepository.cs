using Pocs.Packages.Common.Models.FinView;

namespace PocEntityFramework.Interfaces
{
    public interface ITransactionRepository
    {
        Task<Transaction> SaveNewTransaction(Transaction transaction);
    }
}