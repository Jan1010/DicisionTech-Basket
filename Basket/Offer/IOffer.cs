using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.Offer
{
    public interface IOffer
    {
        decimal GetDiscount(IReadOnlyCollection<Product> products);
    }
}
