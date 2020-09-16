using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PetShop.Business;
using PetShop.Model;
using System.Threading.Tasks;



namespace SaveOrders
{
    public static class Orders
    {
        [FunctionName("SaveOrders")]
        public static async Task<bool> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req)
        {
            //log.LogInformation("C# HTTP trigger function processed a request.");

            //string requestBody = new StreamReader(req.Body).ReadToEnd();
            ////log.LogInformation("Input:" + requestBody);
            //Order order = JsonConvert.DeserializeObject<Order>(requestBody);

            //var orderService = new OrderService();
            //return orderService.SaveData(order);

            return await Task.FromResult(true);
        }
    }
}