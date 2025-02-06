using Microsoft.EntityFrameworkCore;
using Product_Managementmvc.DataAccess.DBModel;

namespace Product_Managementmvc.DataAccess
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);



            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Bottle",
                    Price = 9769
                },
                new Product
                {
                    Id = 2,
                    Name = "Chain",
                    Price = 89785

                });

        }
    }
}
