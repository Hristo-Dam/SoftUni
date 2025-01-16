using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopDatabase.Data.Models;

namespace ShopDatabase.Data
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<ShopProduct> ShopProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API

            // Composite key for a many-to-many relation - You CAN NOT replace with attributes
            modelBuilder.Entity<ShopProduct>()
                .HasKey(sp => new {sp.ShopId, sp.ProductId});

            // Many-to-Many with fluent API - You CAN replace with attributes
            modelBuilder.Entity<ShopProduct>()
                .HasOne(sp => sp.Shop)
                .WithMany(s => s.ShopProducts)
                .HasForeignKey(sp => sp.ShopId);

            modelBuilder.Entity<ShopProduct>()
                .HasOne(sp => sp.Product)
                .WithMany(p => p.ShopProducts)
                .HasForeignKey(sp => sp.ProductId);
            //------------------------------
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ShopDatabaseCF;Integrated Security=True;TrustServerCertificate=True;");
            }
        }

    }
}
