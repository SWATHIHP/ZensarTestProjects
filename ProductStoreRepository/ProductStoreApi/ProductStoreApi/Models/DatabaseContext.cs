using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProductStoreApi.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-I5Q6G9IT\\SQLEXPRESS;Database=ProductDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
