using System.Collections.Generic;

namespace VendingMachine.Services
{
    public interface IChangeService
    {
        // key => money value
        // value => money quantity in the machine 
        public Dictionary<decimal, int> CalculateChange(decimal enteredAmount, decimal actualPrice);
        public void DespinseChange(Dictionary<decimal, int> change);
    }
}
