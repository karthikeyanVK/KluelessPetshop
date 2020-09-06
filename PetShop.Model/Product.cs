using System;

namespace PetShop.Model
{
    public class Product
    {

        public string ProductName { get; set; }
        public Guid ProductId { get; set; }

        public int AvailableQuantity { get; set; }
    }
}