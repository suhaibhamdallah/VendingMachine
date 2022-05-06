using FluentValidation;
using VendingMachine.Enums;
using VendingMachine.Models;

namespace VendingMachine.Validators
{
    public class CardValidator : AbstractValidator<Card>
    {
        public CardValidator()
        {
            RuleFor(card => card.Currency)
                .Equal(Currency.USD)
                .WithMessage("Only accept USD currency.");
        }
    }
}
