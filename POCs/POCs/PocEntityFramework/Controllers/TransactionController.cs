using Microsoft.AspNetCore.Mvc;
using PocEntityFramework.Interfaces;
using PocEntityFramework.Validators;
using Pocs.Packages.Common.Models.FinView;

namespace PocEntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionWorker _transactionWorker;
        private readonly TransactionValidator _transactionValidator;

        public TransactionController(ITransactionWorker transactionWorker, TransactionValidator transactionValidator)
        {
            _transactionWorker = transactionWorker;
            _transactionValidator = transactionValidator;
        }

        [HttpPost]
        public async Task<ActionResult<Transaction>> AddTransaction(Transaction transaction)
        {
            var validation = _transactionValidator.Validate(transaction);

            if (!validation.IsValid)
                return BadRequest(
                    new { 
                        Message = "The pay has errors in it",
                        validation.Errors }
                    );
            return Ok(await _transactionWorker.AddTransaction(transaction));
        }
    }
}