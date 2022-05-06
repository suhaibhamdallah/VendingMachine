using System;
using System.Collections.Generic;
using System.Linq;
using VendingMachine.Models;

namespace VendingMachine.Repositories
{
    public class SnackItemsRepository : ISnackItemRepository
    {
        private List<SnackItem> _snackItems;

        public SnackItemsRepository()
        {
            _snackItems = new List<SnackItem>();
        }

        public void SeedSnackSlot(int numOfRows, int numOfColumns)
        {
            // Just for initialize dummy price & quantity
            var randomGenerator = new Random();
            var minAcceptedValueForPrice = 0.10m;

            _snackItems.RemoveAll(item => true);

            for (int i = 1; i <= numOfRows * numOfColumns; i++)
            {
                _snackItems.Add(new SnackItem(i, $"Item #{i}", Decimal.Round((decimal)randomGenerator.Next(1, 150) * minAcceptedValueForPrice, 2, MidpointRounding.AwayFromZero), randomGenerator.Next(1, 10)));
            }
        }

        public SnackItem GetSnackItem(int id)
        {
            return _snackItems.ElementAt(id - 1);
        }

        public void DecreaseSnackItemQuantity(int id)
        {
            _snackItems.ElementAt(id - 1).Quantity--;
        }
    }
}
