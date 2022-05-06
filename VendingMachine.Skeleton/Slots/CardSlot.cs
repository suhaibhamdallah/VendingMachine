using VendingMachine.Skeleton.Models;

namespace VendingMachine.Skeleton.Slots
{
    public class CardSlot : IChargeableSlot<Card>
    {
        public decimal CurrentBalance { get; set; }

        public bool TobUpBalance(Card card)
        {
            throw new System.NotImplementedException();
        }
    }
}
