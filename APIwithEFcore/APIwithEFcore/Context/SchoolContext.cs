using Microsoft.EntityFrameworkCore;

namespace APIwithEFcore.Context
{
    public class SchoolContext : DbContext
    {
        IConfiguration Configuration { get; }

        public SchoolContext(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnetion"));
        }
    }
}
