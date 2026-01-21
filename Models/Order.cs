namespace MiniGroceryOrderSystem.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Product? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
