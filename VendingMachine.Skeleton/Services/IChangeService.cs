using System.Collections.Generic;

namespace VendingMachine.Skeleton.Services
{
    public interface IChangeService
    {
        public Dictionary<decimal, int> CalculateChange(decimal enteredAmount, decimal actualPrice);
        public void DespinseChange(Dictionary<decimal, int> change);
    }
}
