using Microsoft.AspNetCore.Mvc;
using PocEntityFramework.Interfaces;
using PocEntityFramework.Validators;
using Pocs.Packages.Common.Exceptions;
using Pocs.Packages.Common.Models.FinView;
using System.Security.Cryptography;

namespace PocEntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private ITransactionWorker _transactionWorker;
        private readonly TransactionValidator _transactionValidator;

        public TransactionController(ITransactionWorker transactionWorker, TransactionValidator transactionValidator)
        {
            _transactionWorker = transactionWorker;
            _transactionValidator = transactionValidator;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Transaction>>> ListTransactions(TransactionFilter filter)
        {
            try
            {
                return Ok(await _transactionWorker.ListTransactions(filter));
            }
            catch (NotFoundException)
            {
                return NotFound("The filter aplied didn't return any transaction");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Transaction>> AddTransaction(Transaction transaction)
        {
            var validation = _transactionValidator.Validate(transaction);

            if (!validation.IsValid)
                return BadRequest(
                    new
                    {
                        Message = "The payload has errors in it",
                        validation.Errors
                    }
                    );

            return Ok(await _transactionWorker.AddTransaction(transaction));
        }

        [HttpPut]
        public async Task<ActionResult<Transaction>> EditTransaction(Transaction transaction)
        {
            var validation = _transactionValidator.Validate(transaction);

            if (!validation.IsValid)
                return BadRequest(
                    new
                    {
                        Message = "The payload has errors in it",
                        validation.Errors
                    }
                    );

            return Ok(await _transactionWorker.UpdateTransaction(transaction));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTransaction(int Id)
        {
            try
            {
                return Ok(await _transactionWorker.DeleteTransaction(Id));
            }
            catch(NotFoundException)
            {
                return NotFound("There is no Transaction that corresponds to the given Id!");
            }
        }
    }
}