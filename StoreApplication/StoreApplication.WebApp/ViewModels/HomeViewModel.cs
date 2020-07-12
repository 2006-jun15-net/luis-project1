using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplication.WebApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductsOnSale { get; set; }
    }
}
