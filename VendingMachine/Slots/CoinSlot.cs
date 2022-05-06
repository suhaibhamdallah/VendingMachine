using VendingMachine.Models;
using VendingMachine.Validators;

namespace VendingMachine.Slots
{
    public class CoinSlot : IChargeableSlot<Coin>
    {
        public decimal CurrentBalance { get; set; }

        public bool TobUpBalance(Coin coin)
        {
            if (coin == null) return false;

            var coinValidator = new CoinValidator();
            var coinValidatorResult = coinValidator.Validate(coin);

            if (coinValidatorResult.IsValid)
            {
                CurrentBalance = coin.Amount;
                return true;
            }
            else
            {
                foreach (var error in coinValidatorResult.Errors)
                {
                    System.Console.WriteLine(error.ErrorMessage);
                }
                return false;
            }
        }
    }
}
