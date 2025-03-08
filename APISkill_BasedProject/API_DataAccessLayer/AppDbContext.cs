using API_DataAccessLayer.DBModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace API_DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<ProjectSkill> ProjectsSkills { get; set; }

        public DbSet<ProjectUser> ProjectUsers { get; set; }

        public DbSet<UserSkill> UserSkills { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.ConfigureWarnings(warning => warning.Ignore(RelationalEventId.PendingModelChangesWarning));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<UserSkill>()
                .HasKey(us => new { us.UserId, us.SkillId });

            modelBuilder.Entity<UserSkill>()
                .HasOne(us => us.User)
                .WithMany(u => u.UserSkills)
                .HasForeignKey(us => us.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserSkill>()
                .HasOne(us => us.Skill)
                .WithMany(s => s.UserSkills)
                .HasForeignKey(us => us.SkillId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProjectSkill>()
                .HasKey(ps => new { ps.ProjectId, ps.SkillId });

            modelBuilder.Entity<ProjectSkill>()
                .HasOne(ps => ps.Project)
                .WithMany(p => p.Skill)
                .HasForeignKey(ps => ps.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProjectSkill>()
                .HasOne(ps => ps.Skill)
                .WithMany(s => s.ProjectSkills)
                .HasForeignKey(ps => ps.SkillId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProjectUser>()
                .HasKey(pu => new { pu.UserId, pu.ProjectId });



            modelBuilder.Entity<ProjectUser>()
                .HasOne(pu => pu.User)
                .WithMany(u => u.ProjectUsers)
                .HasForeignKey(pu => pu.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProjectUser>()
                .HasOne(pu => pu.Project)
                .WithMany(p => p.ProjectUsers)
                .HasForeignKey(pu => pu.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Project>()
                    .HasOne(p => p.CreatedByUser)
                    .WithMany(u => u.Projects)
                    .HasForeignKey(p => p.CreatedBy)
                    .OnDelete(DeleteBehavior.NoAction);


            var hashedPassword = BCrypt.Net.BCrypt.HashPassword("Preet@123");

            modelBuilder.Entity<User>()
                .HasData(
                new User
                {
                    UserId = 1,
                    Name = "Preethu",
                    Email = "pspreethu05@gmail.com",
                    Password = hashedPassword,
                });

            modelBuilder.Entity<Profile>()
                .HasData(
                new Profile
                {
                    ProfileId = 1,
                    Bio = "Passionate coder",
                    LinkedinURl = "https://www.example.com/",
                    UserId = 1,

                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
