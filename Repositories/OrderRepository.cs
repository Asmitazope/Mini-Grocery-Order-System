using MiniGroceryOrderSystem.API.Data;
using MiniGroceryOrderSystem.API.Models;

namespace MiniGroceryOrderSystem.API.Repositories
{
    public class OrderRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public OrderRepository(ApplicationDBContext context)
        {
            _dbContext = context; 
        }
        public async Task AddOrders(Order order) => await _dbContext.Orders.AddAsync(order);
        
    }
}
