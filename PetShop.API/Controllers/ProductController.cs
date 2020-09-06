using System.Collections.Generic;
using PetShop.Business;
using PetShop.Model;
using Microsoft.AspNetCore.Mvc;

namespace PetShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/Product
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var productService = new ProductService();
            return productService.GetData();
        }

        // POST: api/Product
        [HttpPost]
        public bool Post([FromBody]Product product)
        {
            var productService = new ProductService();
            return productService.AddProduct(product);
        }
    }
}
