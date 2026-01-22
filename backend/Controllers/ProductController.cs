using Microsoft.AspNetCore.Mvc;
using MiniGroceryOrderSystem.API.Repositories;
namespace MiniGroceryOrderSystem.API.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepository;

        public ProductController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productRepository.GetAllProducts();
            return Ok(products);
        }
    }
}
