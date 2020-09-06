using PetShop.Business;
using PetShop.Model;
using Microsoft.AspNetCore.Mvc;
namespace PetShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderProductsController : ControllerBase
    {

        // POST api/OrderProducts
        [HttpPost]
        public bool Post([FromBody] Order order)
        {
            var orderService = new OrderService();
            return orderService.SaveData(order);
        }
    }
}