using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basket.Offer
{
    public class TwoButtersHalfPriceBreadOffer : IOffer
    {
        public decimal GetDiscount(IReadOnlyCollection<Product> products)
        {
            if (products.Count(t => t.Name == StaticProductCatalog.Butter.Name) > 1)
            {
                if (products.Any(t => t.Name == StaticProductCatalog.Bread.Name))
                {
                    return StaticProductCatalog.Bread.Price * 0.5m;
                }
            }
            return 0;
        }
    }
}
