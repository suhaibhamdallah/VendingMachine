using VendingMachine.Skeleton.Models;

namespace VendingMachine.Skeleton.Repositories
{
    public interface ISnackItemRepository
    {
        public void SeedSnackSlot(int numOfRows, int numOfColumns);
        public SnackItem GetSnackItem(int id);
        public void DecreaseSnackItemQuantity(int id);
    }
}
