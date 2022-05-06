using VendingMachine.Skeleton.Models;

namespace VendingMachine.Skeleton.Slots
{
    public class NotesSlot : IChargeableSlot<Notes>
    {
        public decimal CurrentBalance { get; set; }

        public bool TobUpBalance(Notes notes)
        {
            throw new System.NotImplementedException();
        }
    }
}
