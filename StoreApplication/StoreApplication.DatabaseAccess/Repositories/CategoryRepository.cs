using StoreApplication.DatabaseAccess.Models;
using StoreApplication.Domain.Interfaces;
using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.DatabaseAccess.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreApplicationDBContext _storeApplicationDBContext;
       
        public CategoryRepository(StoreApplicationDBContext storeApplicationDBContext)
        {
            _storeApplicationDBContext = storeApplicationDBContext;
        }

        public IEnumerable<Category> GetAllCategories => _storeApplicationDBContext.Categories;
        
    }
}
