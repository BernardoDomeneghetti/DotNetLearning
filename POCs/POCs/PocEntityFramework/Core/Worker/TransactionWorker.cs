using PocEntityFramework.Interfaces;
using Pocs.Packages.Common.Models.FinView;

namespace PocEntityFramework.Core.Worker
{
    public class TransactionWorker : ITransactionWorker
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionWorker(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<Transaction> AddTransaction(Transaction transaction)
        {
            return await _transactionRepository.SaveNewTransaction(transaction);
        }

        public async Task<Transaction> DeleteTransaction(int id)
        {
            return await _transactionRepository.Delete(id);
        }

        public async Task<List<Transaction>> ListTransactions(TransactionFilter filter)
        {
            return await _transactionRepository.List(filter);
        }

        public async Task<Transaction> UpdateTransaction(Transaction transaction)
        {
            return await _transactionRepository.Update(transaction);
        }
    }
}