using LinkTrackingTool.DataAccess.DBModel;
using Microsoft.EntityFrameworkCore;

namespace LinkTrackingTool.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Link> Links {  get; set; }
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
        }

       
    }
}
