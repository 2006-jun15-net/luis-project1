using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Domain.Models
{
    class ShoppingCart
    {
        ////private readonly StoreApplicationDBContext _storeApplicationDBContext;

        //public string ShoppingCartID { get; set; }
        //public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        //public ShoppingCart(StoreApplicationDBContext storeApplicationDBContext)
        //{
        //    _storeApplicationDBContext = storeApplicationDBContext;
        //}

        //public static ShoppingCart GetCart(IServiceProvider services)
        //{
        //    ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

        //    var context = services.GetService<StoreApplicationDBContext>();
        //    string cartId = session.GetString("CartId")
        //        ?? Guid.NewGuid().ToString();
        //    session.SetString("CartId", cartId);

        //    return new ShoppingCart(context) { ShoppingCartID = cartId };
        //}

        //public void AddToCart(Product product, int amount)
        //{
        //    var shoppingCartItem = _storeApplicationDBContext.ShoppingCartItems.SingleOrDefault(
        //        s => s.Product.ProductId == product.ProductId && s.ShoppingCartID == ShoppingCartID);

        //    if (shoppingCartItem == null)
        //    {
        //        shoppingCartItem = new ShoppingCartItem
        //        {
        //            ShoppingCartID = ShoppingCartID,
        //            Product = product,
        //            Amount = amount
        //        };

        //        _storeApplicationDBContext.ShoppingCartItems.Add(shoppingCartItem);
        //    }
        //    else
        //    {
        //        shoppingCartItem.Amount++;
        //    }

        //    _storeApplicationDBContext.SaveChanges();
        //}

        //public int RemoveFromCart(Product product)
        //{
        //    var shoppingCartItem = _storeApplicationDBContext.ShoppingCartItems.SingleOrDefault(
        //        s => s.Product.ProductId == product.ProductId && s.ShoppingCartID == ShoppingCartID);

        //    var localAmount = 0;

        //    if (shoppingCartItem != null)
        //    {
        //        if (shoppingCartItem.Amount > 1)
        //        {
        //            shoppingCartItem.Amount--;
        //            localAmount = shoppingCartItem.Amount;
        //        }
        //        else
        //        {
        //            _storeApplicationDBContext.ShoppingCartItems.Remove(shoppingCartItem);
        //        }
        //    }

        //    _storeApplicationDBContext.SaveChanges();

        //    return localAmount;
        //}

        //public List<ShoppingCartItem> GetShoppingCartItems()
        //{
        //    return ShoppingCartItems ?? (ShoppingCartItems = _storeApplicationDBContext.ShoppingCartItems
        //        .Where(c => c.ShoppingCartID == ShoppingCartID)
        //        .Include(s => s.Product)
        //        .ToList());
        //}

        //public void ClearCart()
        //{
        //    var cartItems = _storeApplicationDBContext.ShoppingCartItems
        //        .Where(cartItems => cartItems.ShoppingCartID == ShoppingCartID);

        //    _storeApplicationDBContext.ShoppingCartItems.RemoveRange(cartItems);
        //    _storeApplicationDBContext.SaveChanges();
        //}

        //public decimal GetShoppingCartTotal()
        //{
        //    var total = _storeApplicationDBContext.ShoppingCartItems
        //        .Where(c => c.ShoppingCartID == ShoppingCartID)
        //        .Select(c => c.Product.Price * c.Amount).Sum();

        //    return total;
        //}
    }
}
