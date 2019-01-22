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
            var total = _items.Sum(t => t.Price);
            if (_items.Count(t => t.Name == StaticProductCatalog.Butter.Name) > 1)
            {
                if (_items.Any(t => t.Name == StaticProductCatalog.Bread.Name))
                {
                    total -= StaticProductCatalog.Bread.Price * 0.5m;
                }
            }
            return total;
        }
    }
}
