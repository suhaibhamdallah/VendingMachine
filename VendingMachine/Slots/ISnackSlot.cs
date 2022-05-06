using VendingMachine.Models;

namespace VendingMachine.Slots
{
    public interface ISnackSlot
    {
        public bool DespinseSnack(int id);
        public SnackItem GetSnackItem(int id);
    }
}
