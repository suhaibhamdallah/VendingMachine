using System;

namespace VendingMachine.Services
{
    public class KeypadService : IKeypadService
    {
        public KeypadService(int numOfRows, int numOfColumns)
        {
            _numOfRows = numOfRows;
            _numOfColumns = numOfColumns;
        }

        private int _numOfRows { get; set; }
        private int _numOfColumns { get; set; }
        public int CurrentChoice { get; set; }

        public void DisplayAvailableChoices()
        {
            for (int r = 0; r < _numOfRows; r++)
            {
                for (int c = 0; c < _numOfColumns; c++)
                {
                    Console.Write($"{(r + 1) * (c + 1)} \t");
                }
                Console.WriteLine();
            }
        }

        public int ReadChoice()
        {
            var choice = 0;

            bool isNotValidChoice = true;

            do
            {
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if ((choice >= 1 && choice <= (_numOfColumns * _numOfRows)) || choice == 0)
                    {
                        CurrentChoice = choice;
                        break;
                    }
                    Console.WriteLine($"Please enter number from 1 to {_numOfColumns * _numOfRows}");
                }
                catch
                {
                    Console.WriteLine($"Please enter number from 1 to {_numOfColumns * _numOfRows}");
                }
            } while (isNotValidChoice);

            return CurrentChoice;
        }
    }
}
