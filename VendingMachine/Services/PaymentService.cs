using System;
using System.Collections.Generic;
using VendingMachine.Enums;
using VendingMachine.Models;
using VendingMachine.Slots;

namespace VendingMachine.Services
{
    public class PaymentService : IPaymentService
    {
        public decimal TotalPaidAmount { get; set; }
        private readonly CoinSlot _coinSlot;
        private readonly CardSlot _cardSlot;
        private readonly NotesSlot _notesSlot;

        public PaymentService()
        {
            _coinSlot = new CoinSlot();
            _cardSlot = new CardSlot();
            _notesSlot = new NotesSlot();
        }

        public IEnumerable<string> GetAvailablePaymentMethods()
        {
            return Enum.GetNames(typeof(PaymentMethods));
        }

        public bool PayWithCoins(Coin coin)
        {
            if (_coinSlot.TobUpBalance(coin))
            {
                TotalPaidAmount += _coinSlot.CurrentBalance;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PayWithNotes(Notes notes)
        {
            if (_notesSlot.TobUpBalance(notes))
            {
                TotalPaidAmount += _notesSlot.CurrentBalance;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PayWithCard(Card card)
        {
            if (_cardSlot.TobUpBalance(card))
            {
                TotalPaidAmount += _cardSlot.CurrentBalance;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
