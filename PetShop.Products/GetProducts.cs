using System.Collections.Generic;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PetShop.Model;
using PetShop.Business;
using System.Threading.Tasks;
using System;

namespace PetShop.Products
{
    public static class GetProducts
    {
        [FunctionName("GetProducts")]
        public async static Task<IEnumerable<Product>> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");



            //var productService = new ProductService();
            //var productResult = await Task.FromResult(productService.GetData());
            //return productResult;

            var products = new List<Product>
            {
                new Product
                {
                    AvailableQuantity = 10,
                    ProductId = Guid.NewGuid(),
                    ProductName = "Parrot"

                }
            };

            return await Task.FromResult(products);

        }

    }
}