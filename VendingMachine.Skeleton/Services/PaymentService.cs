using System.Collections.Generic;
using VendingMachine.Skeleton.Models;

namespace VendingMachine.Skeleton.Services
{
    public class PaymentService : IPaymentService
    {
        public decimal TotalPaidAmount { get; set; }
        private readonly CoinSlot _coinSlot;
        private readonly CardSlot _cardSlot;
        private readonly NotesSlot _notesSlot;

        public PaymentService()
        {
        }

        public IEnumerable<string> GetAvailablePaymentMethods()
        {
            throw new System.NotImplementedException();
        }

        public bool PayWithCoins(Coin coin)
        {
            throw new System.NotImplementedException();
        }

        public bool PayWithNotes(Notes notes)
        {
            throw new System.NotImplementedException();
        }

        public bool PayWithCard(Card card)
        {
            throw new System.NotImplementedException();
        }
    }
}
