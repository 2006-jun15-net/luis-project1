using StoreApplication.Domain.Interfaces;
using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Domain.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{CategoryId = 1, CategoryName = "Groceries", CategoryDescription = "Fresh Produce" +
                " daiy, baked goods, and meat" },
            new Category {CategoryId = 2, CategoryName = "Sporting Goods", CategoryDescription = "Equpiment and clothing that are" +
                " used in or for sports"}
        };
    }
}
