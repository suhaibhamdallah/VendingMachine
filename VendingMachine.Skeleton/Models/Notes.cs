using VendingMachine.Skeleton.Enums;

namespace VendingMachine.Skeleton.Models
{
    public class Notes : IMoney
    {
        public Notes(decimal amount, Currency currency)
        {
        }

        public decimal Amount { get; set; }

        public Currency Currency { get; set; }
    }
}
