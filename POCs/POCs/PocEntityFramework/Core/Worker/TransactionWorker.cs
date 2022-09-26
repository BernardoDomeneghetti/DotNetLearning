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
    }
}