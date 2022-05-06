using FluentValidation.TestHelper;
using NUnit.Framework;
using VendingMachine.Enums;
using VendingMachine.Models;
using VendingMachine.Validators;

namespace VendingMachine.Tests.ModelsTests
{
    [TestFixture]
    public class NotesShould
    {
        private NotesValidator _notesValidator;

        [SetUp]
        public void SetUp()
        {
            _notesValidator = new NotesValidator();
        }

        [TestCase(20, Currency.USD)]
        [TestCase(50, Currency.USD)]
        public void ValidNotes(decimal notesAmount, Currency currency)
        {
            //-- Assert 
            var notes = new Notes(notesAmount, currency);

            //-- Act
            var actualResult = _notesValidator.TestValidate(notes);

            //-- Assert
            Assert.IsTrue(actualResult.IsValid);
        }

        [TestCase(100, Currency.USD)]
        [TestCase(10, Currency.USD)]
        [TestCase(20, Currency.ILS)]
        [TestCase(50, Currency.EUR)]
        [TestCase(100, Currency.AUD)]
        public void InValidNotes(decimal notesAmount, Currency currency)
        {
            //-- Assert 
            var notes = new Notes(notesAmount, currency);

            //-- Act
            var actualResult = _notesValidator.TestValidate(notes);

            //-- Assert
            Assert.IsFalse(actualResult.IsValid);
        }
    }
}
