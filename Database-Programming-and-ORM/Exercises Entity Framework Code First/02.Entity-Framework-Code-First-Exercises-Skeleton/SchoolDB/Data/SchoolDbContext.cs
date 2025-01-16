using Microsoft.EntityFrameworkCore;
using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDB.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SchoolDB;Integrated Security=True;TrustServerCertificate=True;");
            }
        }
    }
}
