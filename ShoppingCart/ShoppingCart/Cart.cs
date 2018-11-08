using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Cart
    {
       public List<Products> CartItems = new List<Products>();

       

        public void AddItemToCart(Products product)
        {
            CartItems.Add(product);
        }

        public void RemoveItemFromCart(Products product)
        {
            CartItems.Remove(product);
        }


        public decimal CalculateCartTotal(Member member)
        {
            decimal total = 0m;

            foreach (var item in CartItems)
            {
                total += item.Price;
            }         

            return total * (1-member.GetDiscountPercent());
        }


    }
}
