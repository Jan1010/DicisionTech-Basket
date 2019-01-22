using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Basket
{
    public class Basket
    {
        private readonly List<Product> _items = new List<Product>();
        public IReadOnlyCollection<Product> Items => new ReadOnlyCollection<Product>(_items);

        public void AddProduct(Product product)
        {
            _items.Add(product);
        }

        public decimal GetTotal()
        {
            return _items.Sum(t => t.Price);
        }
    }
}
