using System.Collections.Generic;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PetShop.Business;
using PetShop.Model;
using System.Threading.Tasks;

namespace PetShop.Products
{
    public static class SaveProduct
    {
        [FunctionName("SaveProduct")]
        public static async Task<bool> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            //log.LogInformation("C# HTTP trigger function processed a request.");

            //string requestBody = new StreamReader(req.Body).ReadToEnd();
            //log.LogInformation("Input:" + requestBody);
            //Product product = JsonConvert.DeserializeObject<Product>(requestBody);

            //var productService = new ProductService();
            //return productService.AddProduct(product);

            return await Task.FromResult(true);
        }
    }
}