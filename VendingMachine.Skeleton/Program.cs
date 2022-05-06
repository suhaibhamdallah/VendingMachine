using VendingMachine.Skeleton.Models;
using VendingMachine.Skeleton.Services;
using VendingMachine.Skeleton.Slots;

namespace VendingMachine.Skeleton
{
    public class Program
    {
        private static readonly SnackSlot _snackSlot;
        private static readonly PaymentService _paymentService;
        private static readonly ChangeService _changeSercice;

        public static void Main(string[] args)
        {
        }

        private static void Initialize()
        {
        }

        private static SnackItem SelectValidItemOption()
        {
            throw new System.NotImplementedException();
        }

        private static decimal StartPaymentProcess()
        {
            throw new System.NotImplementedException();
        }

        private static int GetSelectedKeypadOptionChosen(int numOfKeypadRows, int numOfKeypadColumns, bool shouldDisplayChoices)
        {
            throw new System.NotImplementedException();
        }

        private static bool CkeckAvailibitlyFromSelectedItem(SnackItem selectedItem)
        {
            throw new System.NotImplementedException();
        }

        private static SnackItem GetSnackItem(int itemId)
        {
            throw new System.NotImplementedException();
        }
    }
}
