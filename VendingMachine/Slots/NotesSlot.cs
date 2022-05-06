using VendingMachine.Models;
using VendingMachine.Validators;

namespace VendingMachine.Slots
{
    public class NotesSlot : IChargeableSlot<Notes>
    {
        public decimal CurrentBalance { get; set; }

        public bool TobUpBalance(Notes notes)
        {
            if (notes == null) return false;

            var notesValidator = new NotesValidator();
            var notesValidatorResult = notesValidator.Validate(notes);

            if (notesValidatorResult.IsValid)
            {
                CurrentBalance = notes.Amount;
                return true;
            }
            else
            {
                foreach (var error in notesValidatorResult.Errors)
                {
                    System.Console.WriteLine(error.ErrorMessage);
                }
                return false;
            }
        }
    }
}
