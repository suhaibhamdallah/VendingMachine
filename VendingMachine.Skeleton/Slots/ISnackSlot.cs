using VendingMachine.Skeleton.Models;

namespace VendingMachine.Skeleton.Slots
{
    public interface ISnackSlot
    {
        public bool DespinseSnack(int id);
        public SnackItem GetSnackItem(int id);
    }
}
