using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StoreApplication.DatabaseAccess.Models;
using StoreApplication.Domain.Interfaces;
using StoreApplication.Domain.Models;

namespace StoreApplication.DatabaseAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly StoreApplicationDBContext _storeApplicationDBContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository (StoreApplicationDBContext storeApplicationDBContext, ShoppingCart shoppingCart)
        {
            _storeApplicationDBContext = storeApplicationDBContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            _storeApplicationDBContext.Orders.Add(order);
            _storeApplicationDBContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();

            foreach(var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    Price = shoppingCartItem.Product.Price,
                    ProductId = shoppingCartItem.Product.ProductId,
                    OrderId = order.OrderId
                };

                _storeApplicationDBContext.OrderDetails.Add(orderDetail);
            }

            _storeApplicationDBContext.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            var entities = _storeApplicationDBContext.OrderDetails
                .Include(o => o.Order)
                .ToList();
            var orders = entities.Select(e => new Order
                (
                    e.OrderId,
                    e.Order.FirstName,
                    e.Order.LastName,
                    e.Order.OrderPlaced,
                    e.Order.OrderDetails,
                    e.Order.OrderTotal
                ));


            return orders;
        }

        public Order GetById(int id)
        {
            var entity = _storeApplicationDBContext.OrderDetails
                .Include(o => o.Order)
                .Include(o => o.Product)
                .First(o => o.OrderId == id);
            Order order = new Order {
                OrderId = entity.OrderId,
                FirstName = entity.Order.FirstName,
                LastName = entity.Order.LastName,
                OrderDetails = entity.Order.OrderDetails,
                OrderPlaced = entity.Order.OrderPlaced,
                OrderTotal = entity.Order.OrderTotal 
            };

            if(entity.OrderId == order.OrderId)
            {
                order.OrderDetails.Add(entity);
               
            }
            return order;


        }

        public Order GetOrdersByName(string firstName, string lastName)
        {

            var entities = _storeApplicationDBContext.OrderDetails.Include(o => o.Order)
                .Include(o => o.Product)
                .Where(o => o.Order.FirstName == firstName).Where(o => o.Order.LastName == lastName);

            var orders = entities.Select(e => new Order
            (
              e.OrderId,
              e.Order.FirstName,
              e.Order.LastName,
              e.Order.OrderPlaced,
              e.Order.OrderDetails,
              e.Order.OrderTotal
            ));

            foreach (var entity in entities)
            {
               foreach (var order in orders)
                {
                    if (entity.OrderId == order.OrderId)
                    {
                        order.OrderDetails.Add(entity);
                    }
                }
                    
            }

            return (Order)orders;
            
        }

       

        //public IEnumerable<Order> GetOrderHistory(object model)
        //{
        //    if (model is ApplicationUser)
        //    {
        //        ApplicationUser customer = (ApplicationUser)model;
        //        var entities = _storeApplicationDBContext.Orders
        //            .Include(o => o.applicationUser)
        //            .Where(o => o.applicationUser.Id == customer.Id);
        //        var orders = entities.Select(e => new Order
        //        (
        //            e.OrderId,
        //            e.OrderPlaced,

        //            new ApplicationUser
        //            {
        //                Id = e.applicationUser.Id,
        //                FirstName = e.applicationUser.FirstName,
        //                LastName = e.applicationUser.LastName,
        //                UserName = e.applicationUser.UserName
        //            },
        //            e.OrderTotal
        //        ));
        //        foreach (var order in orders.ToList())
        //        {
        //            order.OrderDetails = order.OrderDetails;
        //        }
        //        return orders;
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Can't get order history.");
        //    }

        //}


    }
}
