using Microsoft.EntityFrameworkCore;
using Saturday_ManagingProducts.DataAccess.DBModel;

namespace Saturday_ManagingProducts.DataAccess
{
    public class AppDBContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
           .HasKey(pc => new { pc.ProductId, pc.CategoryId });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Clothing" },
                new Category { Id = 3, Name = "Furniture" }
            );



            base.OnModelCreating(modelBuilder);
        }

    }
}
