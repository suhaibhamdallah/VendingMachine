using FluentValidation;
using System.Collections.Generic;
using VendingMachine.Enums;
using VendingMachine.Models;

namespace VendingMachine.Validators
{
    public class CoinValidator : AbstractValidator<Coin>
    {
        public CoinValidator()
        {
            var acceptedCoins = new List<decimal> { 0.10m, 0.20m, 0.50m, 1m };

            RuleFor(coin => coin.Currency)
                .Equal(Currency.USD)
                .WithMessage("Only accept USD currency.");

            RuleFor(coin => coin.Amount)
                .Must(coinAmount => acceptedCoins.Contains(coinAmount))
                .WithMessage("Only accept 10c, 20c, 50c and 1$.");
        }
    }
}
