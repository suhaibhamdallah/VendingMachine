using FluentValidation;
using System.Collections.Generic;
using VendingMachine.Enums;
using VendingMachine.Models;

namespace VendingMachine.Validators
{
    public class NotesValidator : AbstractValidator<Notes>
    {
        public NotesValidator()
        {
            var acceptedNotes = new List<decimal> { 20, 50 };

            RuleFor(notes => notes.Currency)
                .Equal(Currency.USD)
                .WithMessage("Only accept USD currency.");

            RuleFor(notes => notes.Amount)
                .Must(notesAmount => acceptedNotes.Contains(notesAmount))
                .WithMessage("Only accept 20$ and 50$.");
        }
    }
}
