using VendingMachine.Skeleton.Enums;

namespace VendingMachine.Skeleton.Models
{
    public interface IMoney
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
    }
}
