using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Secureuser.DataAccess.DBModels;

namespace Secureuser.DataAccess
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var hashedPasswordAdmin = BCrypt.Net.BCrypt.HashPassword("Preet@123");
            var hashedPasswordUser = BCrypt.Net.BCrypt.HashPassword("khushi@123");
            var hashedtwo = BCrypt.Net.BCrypt.HashPassword("abhi@123");
            modelBuilder.Entity<User>().HasData(
                    //new User
                    //{
                    //    Id = 1,
                    //    Username = "Preet@gmail.com",
                    //    Password = hashedPasswordAdmin,
                    //    Role = "admin"
                    //},
                    //new User
                    //{
                    //    Id = 2,
                    //    Username = "khushi@gmail.com",
                    //    Password = hashedPasswordUser,
                    //    Role = "user"
                    //},
                    new User
                    {
                        Id = 4,
                        Username = "abhi@gmail.com",
                        Password = hashedtwo,
                        Role = "user"

                    }


                );
        }
    }
}

