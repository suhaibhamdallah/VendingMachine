using VendingMachine.Enums;

namespace VendingMachine.Models
{
    public interface IMoney
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
    }
}
