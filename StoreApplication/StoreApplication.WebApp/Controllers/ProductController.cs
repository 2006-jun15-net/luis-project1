using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreApplication.Domain.Interfaces;

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
        
        public ViewResult List()
        {
            return View(_productRepository.GetAllProducts);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
