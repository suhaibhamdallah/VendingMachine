namespace VendingMachine.Skeleton.Services
{
    public class KeypadService : IKeypadService
    {
        public KeypadService(int numOfRows, int numOfColumns)
        {
        }

        private int _numOfRows { get; set; }
        private int _numOfColumns { get; set; }
        public int CurrentChoice { get; set; }

        public void DisplayAvailableChoices()
        {
        }

        public int ReadChoice()
        {
            throw new System.NotImplementedException();
        }
    }
}
