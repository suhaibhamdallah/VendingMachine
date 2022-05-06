using NUnit.Framework;
using VendingMachine.Enums;
using VendingMachine.Models;
using VendingMachine.Services;

namespace VendingMachine.Tests.ServicesTests
{
    [TestFixture]
    public class PaymentServiceShould
    {
        private PaymentService _paymentService;

        [SetUp]
        public void SetUp()
        {
            _paymentService = new PaymentService();
        }

        [TestCase(10, Currency.USD)]
        [TestCase(20, Currency.USD)]
        [TestCase(50, Currency.USD)]
        [TestCase(100, Currency.USD)]
        public void PayWithCoins(decimal coinAmount, Currency currency)
        {
            //-- Arrange 
            var coin = new Coin(coinAmount, currency);

            //-- Act
            var isSuccessPayTransaction = _paymentService.PayWithCoins(coin);

            //-- Assert
            Assert.IsTrue(isSuccessPayTransaction);
        }

        [TestCase(25, Currency.USD)]
        [TestCase(25, Currency.JOD)]
        [TestCase(20, Currency.SAR)]
        public void PayWithCoinsWithBreakRules(decimal coinAmount, Currency currency)
        {
            //-- Arrange 
            var coin = new Coin(coinAmount, currency);

            //-- Act
            var isSuccessPayTransaction = _paymentService.PayWithCoins(coin);

            //-- Assert
            Assert.IsFalse(isSuccessPayTransaction);
        }
    }
}
