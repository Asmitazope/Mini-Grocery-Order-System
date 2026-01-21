using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniGroceryOrderSystem.API.DTO;
using MiniGroceryOrderSystem.API.Services;

namespace MiniGroceryOrderSystem.API.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _service;
        public OrdersController(OrderService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrders(int productID, int quantity)
        {

        }
    }
}
