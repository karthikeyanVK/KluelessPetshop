using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Database

{
    public static class PetShopDbConfiguration
    {
        public static Guid DefaultCustomerID = Guid.Parse("17EDCACA-C902-431A-B935-A1FCF05CA52A");

        public static void Seed(ModelBuilder modelBuilder)
        {
            var customer = new List<Customer>
            {
                new Customer
                {
                    CustomerId = DefaultCustomerID,
                    CustomerAddress = "Chennai",
                    CustomerName = "Meetup User"
                }
            };
            modelBuilder.Entity<Customer>().HasData(customer);
        }
    }
}
