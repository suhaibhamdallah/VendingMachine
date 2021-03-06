namespace VendingMachine.Skeleton.Slots
{
    public interface IChargeableSlot<T>
    {
        public decimal CurrentBalance { get; set; }
        public bool TobUpBalance(T money);
    }
}
