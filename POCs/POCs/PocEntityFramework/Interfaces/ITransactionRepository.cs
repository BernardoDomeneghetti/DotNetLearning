using Pocs.Packages.Common.Models.FinView;

namespace PocEntityFramework.Interfaces
{
    public interface ITransactionRepository
    {
        Task<Transaction> Delete(int id);
        Task<List<Transaction>> List(TransactionFilter filter);
        Task<Transaction> SaveNewTransaction(Transaction transaction);
        Task<Transaction> Update(Transaction transaction);
    }
}