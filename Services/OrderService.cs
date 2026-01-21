using MiniGroceryOrderSystem.API.Data;
using MiniGroceryOrderSystem.API.Repositories;
using MiniGroceryOrderSystem.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
namespace MiniGroceryOrderSystem.API.Services
{
    public class OrderService
    {
        private readonly ProductRepository productRepository;
        private readonly OrderRepository orderRepository;
        private readonly ApplicationDBContext _context;

        public OrderService(ApplicationDBContext context, ProductRepository product, OrderRepository order)
        {
            _context = context;
            productRepository = product;
            orderRepository = order;
        }
        public async Task<IActionResult> PlaceOrders(int productId, int quantity)
        {
            using var dbOp = await _context.Database.BeginTransactionAsync();

            var product = await productRepository.GetById(productId);

            if (product == null) 
                throw new Exception("Product not found");

            if(product.Stock<=0)
                throw new Exception("Out of stock");

            product.Stock -= quantity;
            productRepository.Update(product);

            var orderRecord = new Order
            {
                ProductId= productId,
                Quantity= quantity,
                TotalPrice=product.Price*quantity,
                CreatedAt= DateTime.UtcNow,
            };
            await orderRepository.AddOrders(orderRecord);
            await _context.SaveChangesAsync();
            await dbOp.CommitAsync();
        }
    }
}
