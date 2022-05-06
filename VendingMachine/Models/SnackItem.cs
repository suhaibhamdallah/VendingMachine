﻿namespace VendingMachine.Models
{
    public class SnackItem
    {
        public SnackItem(int id, string name, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} Price: {Price.ToString("0.00")}";
        }
    }
}
