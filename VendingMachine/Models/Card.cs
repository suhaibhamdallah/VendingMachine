using VendingMachine.Enums;

namespace VendingMachine.Models
{
    public class Card : IMoney
    {
        public Card(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; set; }

        public Currency Currency { get; set; }
    }
}
