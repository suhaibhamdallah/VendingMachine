using VendingMachine.Skeleton.Models;
using VendingMachine.Skeleton.Repositories;

namespace VendingMachine.Skeleton.Slots
{
    public class SnackSlot : ISnackSlot
    {
        private readonly SnackItemsRepository _snackItemRepository;

        public SnackSlot(int numOfRows, int numOfColumns)
        {
        }

        public bool DespinseSnack(int id)
        {
            throw new System.NotImplementedException();
        }

        public SnackItem GetSnackItem(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
