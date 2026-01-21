using MiniGroceryOrderSystem.API.Data;
using Microsoft.EntityFrameworkCore;
using MiniGroceryOrderSystem.API.Models;

namespace MiniGroceryOrderSystem.API.Repositories
{
    public class ProductRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public ProductRepository(ApplicationDBContext applicationDB)
        {
            _dbContext = applicationDB;
        }

        public async Task<List<Product>> GetAllProducts() => await _dbContext.Products.AsNoTracking().ToListAsync();

        public async Task<Product?> GetById(int Id) => await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == Id);

        public void Update(Product product) => _dbContext.Products.Update(product);

    }
}
