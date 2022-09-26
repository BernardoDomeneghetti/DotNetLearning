using PocEntityFramework.Interfaces;
using Pocs.Packages.Common.Models.FinView;

namespace PocEntityFramework.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        public async Task<Transaction> SaveNewTransaction(Transaction transaction)
        {
            return transaction;
        }
    }
}
