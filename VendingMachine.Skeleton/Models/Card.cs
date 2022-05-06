using VendingMachine.Skeleton.Enums;

namespace VendingMachine.Skeleton.Models
{
    public class Card : IMoney
    {
        public Card(decimal amount, Currency currency)
        {
        }

        public decimal Amount { get; set; }

        public Currency Currency { get; set; }
    }
}
