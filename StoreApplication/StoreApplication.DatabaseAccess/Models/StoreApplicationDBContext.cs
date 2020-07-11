using Microsoft.EntityFrameworkCore;
using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace StoreApplication.DatabaseAccess.Models
{
    public class StoreApplicationDBContext : DbContext
    {
        public StoreApplicationDBContext(DbContextOptions<StoreApplicationDBContext> options) :
            base(options)
        { 

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
