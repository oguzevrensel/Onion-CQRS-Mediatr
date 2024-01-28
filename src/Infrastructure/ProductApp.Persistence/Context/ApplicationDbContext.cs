using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name="Pen",Quantity = 10, Value= 100},
                new Product() { Id = Guid.NewGuid(), Name = "Computer", Quantity = 4, Value = 23 },
                new Product() { Id = Guid.NewGuid(), Name = "Fridge", Quantity = 10, Value = 91 },
                new Product() { Id = Guid.NewGuid(), Name = "Book", Quantity = 1, Value = 75 }, 
                new Product() { Id = Guid.NewGuid(), Name = "Phone", Quantity = 9, Value = 55 }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
