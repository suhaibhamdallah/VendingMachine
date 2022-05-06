using System.Collections.Generic;
using VendingMachine.Skeleton.Models;

namespace VendingMachine.Skeleton.Services
{
    public interface IPaymentService
    {
        public decimal TotalPaidAmount { get; set; }
        public IEnumerable<string> GetAvailablePaymentMethods();
        public bool PayWithCoins(Coin coin);
        public bool PayWithNotes(Notes notes);
        public bool PayWithCard(Card card);
    }
}
