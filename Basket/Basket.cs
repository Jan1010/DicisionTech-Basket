using System;
using System.Collections.Generic;

namespace Basket
{
    public class Basket
    {
        public List<Product> Items { get; set; } = new List<Product>();
        public void AddProduct(Product product)
        {
            Items.Add(product);
        }
    }
}
