using LinkTrackerTool.DataAccess.DBModel;
using Microsoft.EntityFrameworkCore;

namespace LinkTrackerTool.DataAccess
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Link> Links { get; set; }

    

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
