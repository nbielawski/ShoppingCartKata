using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Products
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Products(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }


    }
}
