using Microsoft.EntityFrameworkCore;
namespace PetShop.Database
{
    public class PetShopContext : DbContext
    {
        public PetShopContext()
           : base()
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(_configuration.GetValue<string>("DbConnectionString:DefaultConnection"));
            optionsBuilder.UseSqlServer(
                "Server=tcp:aksworkshop.database.windows.net,1433;Initial Catalog=petshop;Persist Security Info=False;User ID=aksworkshop;Password=BGSoXD7138EQ;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            PetShopDbConfiguration.Seed(modelBuilder);
        }
    }
}
 