﻿using Microsoft.EntityFrameworkCore;

namespace SRRSBakery.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public void AddToCart(Item item, int amount)
        {
            var shoppingCartItem =
                    _appDbContext.Shoppingitemcart.SingleOrDefault(
                        s => s.item.ItemId == item.ItemId && s.ShoppingCartId == ShoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    item = item,
                    Amount = 1
                };

                _appDbContext.Shoppingitemcart.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {

            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            //for new person 1 it will create ??

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        /* public int RemoveFromCart(Pie pie)
         {
             var shoppingCartItem =
                     _appDbContext.ShoppingCartItems.SingleOrDefault(
                         s => s.Pie.PieId == pie.PieId && s.ShoppingCartId == ShoppingCartId);

             var localAmount = 0;

             if (shoppingCartItem != null)
             {
                 //if they have more than 1 apple pie, you should reduce the count
                 if (shoppingCartItem.Amount > 1)
                 {
                     shoppingCartItem.Amount--;
                     localAmount = shoppingCartItem.Amount;
                 }
                 else
                 {
                     _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                 }
             }

             _appDbContext.SaveChanges();

             return localAmount;
         }*/
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _appDbContext.Shoppingitemcart.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.item)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext
                .Shoppingitemcart
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _appDbContext.Shoppingitemcart.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.Shoppingitemcart.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.item.Price * c.Amount).Sum();
            return total;
        }


    }
}