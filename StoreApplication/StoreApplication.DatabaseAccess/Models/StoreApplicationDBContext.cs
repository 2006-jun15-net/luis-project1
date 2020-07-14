using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace StoreApplication.DatabaseAccess.Models
{
    public class StoreApplicationDBContext : IdentityDbContext<IdentityUser>
    {
        public StoreApplicationDBContext(DbContextOptions<StoreApplicationDBContext> options) :
            base(options)
        { 

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Groceries" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Sporting Goods" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "School Supplies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Electronics" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Toys" });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Cabbage",
                Price = 1.99M,
                Description = "Head of cabbage",
                CategoryId = 1,
                ImageUrl = "\\Images\\Cabbage.jpg",
                ImageThumbnailUrl = "\\Images\\Cabbage.jpg",
                IsInStock=true,
                IsOnSale=true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Baseball Bat",
                Price = 36.99M,
                Description = "High-Quality aluminum baseball bat",
                CategoryId = 2,
                ImageUrl = "\\Images\\BaseballBat.jpg",
                ImageThumbnailUrl = "\\Images\\BaseballBat.jpg",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "College Ruled Notebook",
                Price = 2.99M,
                Description = "Multi-purpose college ruled notebook",
                CategoryId = 3,
                ImageUrl = "\\Images\\Notebook.jpg",
                ImageThumbnailUrl = "\\Images\\Notebook.jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "IPhone",
                Price = 399.99M,
                Description = "Apple IPhone SE",
                CategoryId = 4,
                ImageUrl = "\\Images\\IponeSE.png",
                ImageThumbnailUrl = "\\Images\\IphoneSE.png",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Lego Set: Kylo Ren Shuttle",
                Price = 129.95M,
                Description = "Lego Star Wars Kylo Ren's Shuttle",
                CategoryId = 5,
                ImageUrl = "\\Images\\LegoKyloRen.jpg",
                ImageThumbnailUrl = "\\Images\\LegoKyloRen.jpg",
                IsInStock = true,
                IsOnSale = false
            });

            

        }

    }
}
