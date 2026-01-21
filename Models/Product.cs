namespace MiniGroceryOrderSystem.API.Models
{
    public class Product
    {
        public int Id { get; set; } = 1;
        public string? Name { get; set; } = "Laptop";
        public decimal? Price { get; set; } = 50000;
        public int Stock { get; set; } = 50;
    }
}
