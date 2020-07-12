using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Domain.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public string ShoppingCartID { get; set; }

        public Product Product { get; set; }

        public int Amount { get; set; }
    }
}
