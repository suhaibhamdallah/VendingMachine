using VendingMachine.Models;
using VendingMachine.Repositories;

namespace VendingMachine.Slots
{
    public class SnackSlot : ISnackSlot
    {
        private readonly SnackItemsRepository _snackItemRepository;

        public SnackSlot(int numOfRows, int numOfColumns)
        {
            _snackItemRepository = new SnackItemsRepository();
            _snackItemRepository.SeedSnackSlot(numOfRows, numOfColumns);
        }

        public bool DespinseSnack(int id)
        {
            var selectedSnack = _snackItemRepository.GetSnackItem(id);

            if (selectedSnack.Quantity == 0)
            {
                return false;
            }
            else
            {
                _snackItemRepository.DecreaseSnackItemQuantity(id);
                return true;
            }
        }

        public SnackItem GetSnackItem(int id)
        {
            return _snackItemRepository.GetSnackItem(id);
        }
    }
}
