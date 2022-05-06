using FluentValidation;
using VendingMachine.Skeleton.Models;

namespace VendingMachine.Skeleton.Validators
{
    public class CoinValidator : AbstractValidator<Coin>
    {
        public CoinValidator()
        {
        }
    }
}
