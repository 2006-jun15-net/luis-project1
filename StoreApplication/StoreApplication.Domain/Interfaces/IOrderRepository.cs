using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Domain.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        Order GetById(int id);
        //IEnumerable<Order> GetOrderHistory(object model);
        public void CreateOrder(Order order);
        Order GetOrdersByName(string firstName, string lastName);
    }
}
