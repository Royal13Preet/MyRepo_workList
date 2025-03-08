using Microsoft.EntityFrameworkCore;

namespace Sample_Webapi
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }    

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
