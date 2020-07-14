using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Domain.Interfaces
{
    interface IStoreRepository
    {
        IEnumerable<Store> GetAll();
        Store GetById(int id);
        Dictionary<Product, int> GetAllProducts(int id);
        void Update(Store location);
    }
}
