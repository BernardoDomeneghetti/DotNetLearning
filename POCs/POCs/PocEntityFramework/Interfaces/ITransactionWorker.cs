using Pocs.Packages.Common.Models.FinView;

namespace PocEntityFramework.Interfaces
{
    public interface ITransactionWorker
    {
        Task<Transaction> AddTransaction(Transaction transaction);
        Task<Transaction> DeleteTransaction(int id);
        Task<List<Transaction>> ListTransactions(TransactionFilter filter);
        Task<Transaction> UpdateTransaction(Transaction transaction);
    }
}