using FluentValidation;
using Pocs.Packages.Common.Models.FinView;

namespace PocEntityFramework.Validators
{
    public class TransactionValidator : AbstractValidator<Transaction>
    {
        public TransactionValidator()
        {
            RuleFor(transaction => transaction.Id).NotNull().NotEqual(0);
            RuleFor(transaction => transaction.Description).NotNull().NotEmpty();
            RuleFor(transaction => transaction.ResponsableId).NotNull().NotEqual(0);
            RuleFor(transaction => transaction.CategoryId).NotNull().NotEqual(0);
            RuleFor(transaction => transaction.Value).NotNull().NotEqual(0);
        }
    }
}