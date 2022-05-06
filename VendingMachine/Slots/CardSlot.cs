using VendingMachine.Models;
using VendingMachine.Validators;

namespace VendingMachine.Slots
{
    public class CardSlot : IChargeableSlot<Card>
    {
        public decimal CurrentBalance { get; set; }

        public bool TobUpBalance(Card card)
        {
            if (card == null) return false;

            var cardValidator = new CardValidator();
            var cardValidatorResult = cardValidator.Validate(card);

            if (cardValidatorResult.IsValid)
            {
                CurrentBalance = card.Amount;
                return true;
            }
            else
            {
                foreach (var error in cardValidatorResult.Errors)
                {
                    System.Console.WriteLine(error.ErrorMessage);
                }
                return false;
            }
        }
    }
}
