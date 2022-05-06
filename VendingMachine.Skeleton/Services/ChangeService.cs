using System.Collections.Generic;

namespace VendingMachine.Skeleton.Services
{
    public class ChangeService : IChangeService
    {

        private Dictionary<decimal, int> _moneyCanReturn;

        public ChangeService()
        {
        }

        public Dictionary<decimal, int> CalculateChange(decimal enteredAmount, decimal actualPrice)
        {
            throw new System.NotImplementedException();
        }

        public void DespinseChange(Dictionary<decimal, int> change)
        {
        }
    }
}
