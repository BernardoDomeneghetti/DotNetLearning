using Pocs.Packages.Common.Models.FinView;

namespace PocEntityFramework.Interfaces
{
    public interface ITransactionWorker
    {
        Task<Transaction> AddTransaction(Transaction transaction);
    }
}