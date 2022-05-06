using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using VendingMachine.Services;

namespace VendingMachine.Tests.ServicesTests
{
    [TestFixture]
    public class ChangeServiceShould
    {
        private ChangeService _changeService;

        [SetUp]
        public void Setup()
        {
            _changeService = new ChangeService();
        }

        [Test]
        public void CalculateChange()
        {
            //-- Act
            var enteredAmount = 20m;
            var itemPrice = 5.70m;
            var expectedChange = new Dictionary<decimal, int>
            {
                { 1m, 14 },
                { 0.20m, 1 },
                { 0.10m, 1 }
            };
            var actualChange = _changeService.CalculateChange(enteredAmount, itemPrice);

            //-- Assert
            Assert.AreEqual(expectedChange, actualChange);
        }

        [Test]
        public void DespinseChange()
        {
            //-- Arrange 
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //-- Act
            var enteredAmount = 20m;
            var itemPrice = 15.20m;
            var actualChange = _changeService.CalculateChange(enteredAmount, itemPrice);
            _changeService.DespinseChange(actualChange);
            var actualOutput = stringWriter.ToString();
            var expectedOutput = "Total changes amount: 4.80$\r\nChanges:\r\n1$\r\n1$\r\n1$\r\n1$\r\n0.50$\r\n0.20$\r\n0.10$\r\n";

            //-- Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
