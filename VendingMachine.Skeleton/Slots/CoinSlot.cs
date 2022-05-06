using VendingMachine.Skeleton.Models;

namespace VendingMachine.Skeleton.Slots
{
    public class CoinSlot : IChargeableSlot<Coin>
    {
        public decimal CurrentBalance { get; set; }

        public bool TobUpBalance(Coin coin)
        {
            throw new System.NotImplementedException();
        }
    }
}
