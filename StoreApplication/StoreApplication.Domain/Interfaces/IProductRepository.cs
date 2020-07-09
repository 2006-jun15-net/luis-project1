using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts { get; }
        IEnumerable<Product> GetProductsOnSale { get; }

        Product GetProductById(int CandyId);

        Product GetProductByName(string Name);
    }
}
