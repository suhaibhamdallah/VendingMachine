namespace VendingMachine.Skeleton.Models
{
    public class SnackItem
    {
        public SnackItem(int id, string name, decimal price, int quantity)
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
