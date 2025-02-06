using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DataAccess;

public partial class DataBaseApprochContext : DbContext
{
    public DataBaseApprochContext()
    {
    }

    public DataBaseApprochContext(DbContextOptions<DataBaseApprochContext> options)
        : base(options)
    {

    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warning => warning.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
        new Product { Id = 1, Name = "Laptop", Description = "High-end laptop", Price = 1200.50m, StockQuantity = 10, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
        new Product { Id = 2, Name = "Smartphone", Description = "Latest model", Price = 800.99m, StockQuantity = 25, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
        new Product { Id = 3, Name = "Headphones", Description = "Noise-cancelling", Price = 150.75m, StockQuantity = 50, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
        );

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
