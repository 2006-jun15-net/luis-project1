using Microsoft.EntityFrameworkCore;
using StoreApplication.DatabaseAccess.Models;
using StoreApplication.Domain.Interfaces;
using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreApplication.DatabaseAccess.Repositories
{

    public class ProductRepository : IProductRepository
    {

        private readonly StoreApplicationDBContext _storeApplicationDBContext;

        public ProductRepository(StoreApplicationDBContext storeApplicationDBContext)
        {
            _storeApplicationDBContext = storeApplicationDBContext;
        }

        public IEnumerable<Product> GetAllProducts 
        {
            get
            {
                return _storeApplicationDBContext.Products.Include(p => p.Category);
            }   
        }

        public IEnumerable<Product> GetProductsOnSale
        {
            get
            {
                return _storeApplicationDBContext.Products.Include(p => p.Category)
                    .Where(p => p.IsOnSale);
            }
        }

        public Product GetProductById(int productId)
        {
            return _storeApplicationDBContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public Product GetProductByName(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
