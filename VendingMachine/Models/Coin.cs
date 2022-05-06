using VendingMachine.Enums;

namespace VendingMachine.Models
{
    public class Coin : IMoney
    {
        public Coin(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        /// <summary>
        /// The amount should be the lowest used change 
        /// </summary>
        private decimal _amount;
        public decimal Amount
        {
            get { return _amount / 100; }
            set { _amount = value; }
        }

        public Currency Currency { get; set; }
    }
}
