using System.Collections.Generic;
using VendingMachine.Skeleton.Models;

namespace VendingMachine.Skeleton.Repositories
{
    public class SnackItemsRepository : ISnackItemRepository
    {
        private List<SnackItem> _snackItems;

        public SnackItemsRepository()
        {;
        }

        public void SeedSnackSlot(int numOfRows, int numOfColumns)
        {
        }

        public void DecreaseSnackItemQuantity(int id)
        {
        }

        public SnackItem GetSnackItem(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
