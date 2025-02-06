using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace DataBase_ApprochMVC.Models;

public partial class DataOfMvcContext : DbContext
{
    public DataOfMvcContext()
    {
    }

    public DataOfMvcContext(DbContextOptions<DataOfMvcContext> options)
        : base(options)
    {
    }
    
    //public virtual DbSet<Entity> Entities { get; set; }
    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = PREETHU_GSS\\MSSQLSERVER02; DataBase= DataOfMvc; Trusted_connection = true;TrustServerCertificate = true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //Today, I worked on LINQ queries, JOINS in SQL, and a web API project.I also attended a test.
        modelBuilder.Entity<Brand>(entity =>
        {
            entity.ToTable("Brand");

            
            entity.Property(e => e.BrandName)
                .HasMaxLength(50)
                .HasColumnName("Brand_name");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Category_name");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.BrandId).HasColumnName("Brand_id");
            entity.Property(e => e.CategoryId).HasColumnName("Category_id");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Product_name");

            entity.HasOne(d => d.Brand).WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Brand");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Category");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
