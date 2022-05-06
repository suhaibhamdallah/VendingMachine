using VendingMachine.Enums;

namespace VendingMachine.Models
{
    public class Notes : IMoney
    {
        public Notes(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; set; }

        public Currency Currency { get; set; }
    }
}
