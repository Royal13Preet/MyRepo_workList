using eFclass.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.DataAccess
{
   
        public class BookContext : DbContext
        {
        protected readonly IConfiguration _configuration;

        public BookContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<BookCategory> BookCategories { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<User> Users { get; set; }
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("SqlServerConnection"); 
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.author)
                .WithMany(a => a.Books)
                .HasForeignKey(a => a.AuthorId);
            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });
            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, AuthorName = "Author1" },
                new Author { AuthorId = 2, AuthorName = "author2" });


            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Fiction" },
                new Category { CategoryId = 2, CategoryName = "Non- Fiction" },
                new Category { CategoryId = 3, CategoryName = "Science Fiction" }
            );
            modelBuilder.Entity<Book>().HasData(
                    new Book { BookId = 1, Title = "Book1", AuthorId = 1 },
                    new Book { BookId = 2, Title = "Book2", AuthorId = 1 },
                    new Book { BookId = 3, Title = "book3", AuthorId = 2 }
                );
            modelBuilder.Entity<BookCategory>().HasData(
                new BookCategory { BookId = 1, CategoryId = 1 },
                new BookCategory { BookId = 1, CategoryId = 2 },
                new BookCategory { BookId = 2, CategoryId = 2 },
                new BookCategory { BookId = 3, CategoryId = 3 }
                );



            }
        }
}
