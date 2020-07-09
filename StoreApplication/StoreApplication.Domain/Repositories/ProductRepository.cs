using StoreApplication.Domain.Interfaces;
using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreApplication.Domain.Repositories
{

    public class ProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();

        public IEnumerable<Product> GetAllProducts => new List<Product>
        {
            new Product 
            {
                ProductId = 1,
                Name = "Cabbage",
                Price = 3.95M,
                Description = "A head of cabbage",
                Category = _categoryRepository.GetAllCategories.ToList()[0],
                ImageUrl="https://st3.depositphotos.com/5697988/15888/i/1600/depositphotos_158885864-stock-photo-fresh-head-of-cabbage.jpg",
                IsInStock = true,
                IsOnSale = false,
                ImageThumbnailUrl = "https://via.placeholder.com/50x50.jpg"
            },
            new Product
            {
                ProductId = 2,
                Name = "Baseball Bat",
                Price = 36.95M,
                Description = "Sturdy Aluminum Baseball bat",
                Category = _categoryRepository.GetAllCategories.ToList()[1],
                ImageUrl="https://via.placeholder.com/150.jpg",
                IsInStock = true,
                IsOnSale = false,
                ImageThumbnailUrl = "https://via.placeholder.com/50x50.jpg"
            },
            new Product
            {
                ProductId = 2,
                Name = "Baseball",
                Price = 9.95M,
                Description = "MLB official baseball",
                Category = _categoryRepository.GetAllCategories.ToList()[1],
                ImageUrl="https://via.placeholder.com/150.jpg",
                IsInStock = true,
                IsOnSale = true,
                ImageThumbnailUrl = "https://via.placeholder.com/50x50.jpg"
            }
        };

        public IEnumerable<Product> GetProductsOnSale => throw new NotImplementedException();

        public Product GetProductById(int productId)
        {
            return GetAllProducts.FirstOrDefault(p => p.ProductId == productId);
        }

        public Product GetProductByName(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
