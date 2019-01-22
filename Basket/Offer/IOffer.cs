using System.Collections.Generic;

namespace Basket.Offer
{
    public interface IOffer
    {
        decimal GetDiscount(IReadOnlyCollection<Product> products);
    }
}
