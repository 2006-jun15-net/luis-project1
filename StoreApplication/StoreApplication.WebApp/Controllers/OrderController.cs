using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StoreApplication.DatabaseAccess.Models;
using StoreApplication.Domain.Interfaces;
using StoreApplication.Domain.Models;
using StoreApplication.WebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplication.WebApp.Controllers
{   
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart, UserManager<IdentityUser> userManager)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;

        }

        
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty");

            }
            
            if(ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank you for your order. Enjoy your products";
            return View();
        }

        public IActionResult Details(int OrderId)
        {
            try
            {
                Order order = _orderRepository.GetById(OrderId);
                OrderViewModel orderDetails = new OrderViewModel
                {
                    OrderId = order.OrderId,
                    firstName = order.FirstName,
                    lastName = order.LastName,
                    OrderPlaced = order.OrderPlaced,
                    OrderDetails = order.OrderDetails,
                    OrderTotal = order.OrderTotal
                };
                return View(orderDetails);
            }
            catch (Exception)
            {
                ViewData["ErrorMsg"] = "Order not found.";
                return View(new OrderViewModel());
            }


        }

        public IActionResult OrderHistory()
        {
            try
            {
                var orderHistory = _orderRepository.GetAll();
                List<OrderViewModel> viewModels = new List<OrderViewModel>();
                foreach (var order in orderHistory)
                {
                    viewModels.Add(new OrderViewModel
                    {
                        OrderPlaced = order.OrderPlaced,
                        OrderId = order.OrderId,
                        firstName = order.FirstName,
                        lastName = order.LastName,
                        OrderDetails = order.OrderDetails,
                        OrderTotal = order.OrderTotal
                    });
                }
                return View(viewModels);
            }
            catch (Exception)
            {
                ViewData["ErrorMsg"] = "Invalid customer or customer not detected. Please sign in and try again.";
                return View();
            }


        }
    }
}
