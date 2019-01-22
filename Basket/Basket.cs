using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Basket.Offer;

namespace Basket
{
    public class Basket
    {
        private readonly List<Product> _items = new List<Product>();
        private readonly IEnumerable<IOffer> _offers;
        public IReadOnlyCollection<Product> Items => new ReadOnlyCollection<Product>(_items);

        public Basket(IEnumerable<IOffer> offers)
        {
            _offers = offers;
        }

        public void AddProduct(Product product)
        {
            _items.Add(product);
        }

        public decimal GetTotal()
        {
            var total = _items.Sum(t => t.Price);
            foreach (var offer in _offers)
            {
                total -= offer.GetDiscount(_items);
            }
            return total;
        }
    }
}
