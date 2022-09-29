using PocEntityFramework.Interfaces;
using Pocs.Packages.Common.Models.FinView;

namespace PocEntityFramework.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        public Task<Transaction> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Transaction>> List(TransactionFilter filter)
        {
            throw new NotImplementedException();
        }

        public async Task<Transaction> SaveNewTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> Update(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
