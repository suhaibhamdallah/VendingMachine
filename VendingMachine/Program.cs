using System;
using System.Linq;
using VendingMachine.Enums;
using VendingMachine.Models;
using VendingMachine.Services;
using VendingMachine.Slots;

namespace VendingMachine
{
    public class Program
    {
        private static SnackSlot _snackSlot;
        private static PaymentService _paymentService;
        private static ChangeService _changeSercice;

        public static void Main(string[] args)
        {
            Initialize();

            var selectedSnack = SelectValidItemOption();

            if (selectedSnack == null) Environment.Exit(1);

            Console.WriteLine("###########################");
            Console.WriteLine($"Selected item is available: {selectedSnack}");
            Console.WriteLine("###########################");

            var accumleatedEntredAmount = 0m;

            do
            {
                accumleatedEntredAmount += StartPaymentProcess();
                Console.WriteLine("###########################");
                Console.WriteLine($"Total paid amount: {accumleatedEntredAmount.ToString("0.00")}$");
                Console.WriteLine("###########################");
            } while (accumleatedEntredAmount < selectedSnack.Price);

            _snackSlot.DespinseSnack(selectedSnack.Id);

            if (accumleatedEntredAmount > selectedSnack.Price)
            {
                var change = _changeSercice.CalculateChange(accumleatedEntredAmount, selectedSnack.Price);
                _changeSercice.DespinseChange(change);
            }
        }

        private static void Initialize()
        {
            _snackSlot = new SnackSlot(5, 5);

            _paymentService = new PaymentService();

            _changeSercice = new ChangeService();
        }

        private static SnackItem SelectValidItemOption()
        {
            SnackItem selectedSnack = null;

            do
            {
                var selectedKeypadOption = GetSelectedKeypadOptionChosen(5, 5, true);
                if (selectedKeypadOption == 0) break;
                selectedSnack = GetSnackItem(selectedKeypadOption);
            } while (!CkeckAvailibitlyFromSelectedItem(selectedSnack));

            return selectedSnack;
        }

        private static decimal StartPaymentProcess()
        {
            _paymentService = new PaymentService();
            var availablePaymentMethods = _paymentService.GetAvailablePaymentMethods().ToList();

            Console.WriteLine("Please Choose you payment method: (Press '0' to cancel)");
            for (int i = 1; i <= availablePaymentMethods.Count; i++)
            {
                Console.WriteLine($"{i}. {availablePaymentMethods.ElementAt(i - 1)}");
            }

            bool isSuccessPayment = false;
            switch (GetSelectedKeypadOptionChosen(1, 3, false))
            {
                case (int)PaymentMethods.Card:
                    Console.WriteLine("Enter your card please:");
                    var cardAmount = Convert.ToInt32(Console.ReadLine());
                    isSuccessPayment = _paymentService.PayWithCard(new Card(cardAmount, Currency.USD));
                    break;
                case (int)PaymentMethods.Coins:
                    Console.WriteLine("Enter your coins please:");
                    var coinAmount = Convert.ToInt32(Console.ReadLine());
                    isSuccessPayment = _paymentService.PayWithCoins(new Coin(coinAmount, Currency.USD));
                    break;
                case (int)PaymentMethods.Notes:
                    Console.WriteLine("Enter your notes please:");
                    var notesAmount = Convert.ToInt32(Console.ReadLine());
                    isSuccessPayment = _paymentService.PayWithNotes(new Notes(notesAmount, Currency.USD));
                    break;
                default:
                    System.Diagnostics.Process.Start(AppDomain.CurrentDomain.FriendlyName);
                    Environment.Exit(1);
                    break;
            }

            if (!isSuccessPayment)
            {
                return StartPaymentProcess();
            }
            else
            {
                return _paymentService.TotalPaidAmount;
            }
        }

        private static int GetSelectedKeypadOptionChosen(int numOfKeypadRows, int numOfKeypadColumns, bool shouldDisplayChoices)
        {
            var keypad = new KeypadService(numOfKeypadRows, numOfKeypadColumns);
            if (shouldDisplayChoices)
            {
                keypad.DisplayAvailableChoices();
                Console.WriteLine("Please select your choice: (Press '0' to cancel)");
            }

            return keypad.ReadChoice();
        }

        private static bool CkeckAvailibitlyFromSelectedItem(SnackItem selectedItem)
        {
            return selectedItem.Quantity > 0;
        }

        private static SnackItem GetSnackItem(int itemId)
        {
            return _snackSlot.GetSnackItem(itemId);
        }
    }
}
