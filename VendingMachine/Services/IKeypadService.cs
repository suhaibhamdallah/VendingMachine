﻿namespace VendingMachine.Services
{
    public interface IKeypadService
    {
        public int CurrentChoice { get; set; }
        public void DisplayAvailableChoices();
        public int ReadChoice();
    }
}
