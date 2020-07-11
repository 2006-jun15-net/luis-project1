using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreApplication.Domain.Interfaces;
using StoreApplication.WebApp.ViewModels;

namespace StoreApplication.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        
        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "BestSellers";

            //return View(_productRepository.GetAllProducts);

            var productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.GetAllProducts;
            productListViewModel.CurrentCategory = "Best Sellers";
            return View(productListViewModel);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
