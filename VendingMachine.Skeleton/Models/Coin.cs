using VendingMachine.Skeleton.Enums;

namespace VendingMachine.Skeleton.Models
{
    public class Coin : IMoney
    {
        public Coin(decimal amount, Currency currency)
        {
        }

        private decimal _amount;
        public decimal Amount
        {
            get;
            set;
        }

        public Currency Currency { get; set; }
    }
}
