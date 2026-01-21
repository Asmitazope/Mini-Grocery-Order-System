using MiniGroceryOrderSystem.API.Models;

namespace MiniGroceryOrderSystem.API.DTO
{
    public class OrderDTO
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
