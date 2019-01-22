using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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

        public decimal GetTotal(Basket basket)
        {
            throw new NotImplementedException();
        }
    }
}
