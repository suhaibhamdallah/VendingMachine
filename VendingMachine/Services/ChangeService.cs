using System.Collections.Generic;
using System.Linq;

namespace VendingMachine.Services
{
    public class ChangeService : IChangeService
    {

        private Dictionary<decimal, int> _moneyCanReturn;

        public ChangeService()
        {
            // key => money value
            // value => money quantity in the machine 
            _moneyCanReturn = new Dictionary<decimal, int>();

            _moneyCanReturn.Add(50m, 20);
            _moneyCanReturn.Add(20m, 20);
            _moneyCanReturn.Add(1m, 50);
            _moneyCanReturn.Add(0.50m, 100);
            _moneyCanReturn.Add(0.20m, 100);
            _moneyCanReturn.Add(0.10m, 100);
        }

        public Dictionary<decimal, int> CalculateChange(decimal enteredAmount, decimal actualPrice)
        {
            var amountToReturn = enteredAmount - actualPrice;
            var moneyToReturn = new Dictionary<decimal, int>();

            while (amountToReturn > 0)
            {
                var availableMoneyCanReturn = _moneyCanReturn
                                            .Where(m => m.Value > 0)
                                            .OrderByDescending(m => m.Key)
                                            .ToDictionary(m => m.Key, m => m.Value);

                var change = availableMoneyCanReturn
                                .Where(m => amountToReturn - m.Key >= 0)
                                .FirstOrDefault();

                if (moneyToReturn.ContainsKey(change.Key))
                {
                    moneyToReturn[change.Key]++;
                }
                else
                {
                    moneyToReturn.Add(change.Key, 1);
                }

                amountToReturn -= change.Key;
            }

            return moneyToReturn;
        }

        public void DespinseChange(Dictionary<decimal, int> change)
        {
            var totalAmount = change
                                .Select(m => new { SumOfOneChangeType = m.Key * m.Value })
                                .Sum(m => m.SumOfOneChangeType);

            System.Console.WriteLine($"Total changes amount: {totalAmount.ToString("0.00")}$");

            System.Console.WriteLine("Changes:");
            foreach (var changeItem in change)
            {
                for (int i = 0; i < changeItem.Value; i++)
                {
                    System.Console.WriteLine($"{changeItem.Key}$");
                }
            }
        }
    }
}
