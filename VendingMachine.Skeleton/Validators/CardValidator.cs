using FluentValidation;
using VendingMachine.Skeleton.Models;

namespace VendingMachine.Skeleton.Validators
{
    public class CardValidator : AbstractValidator<Card>
    {
        public CardValidator()
        {
        }
    }
}
