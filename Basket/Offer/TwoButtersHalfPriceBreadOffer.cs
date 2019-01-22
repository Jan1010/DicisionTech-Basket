using System.Collections.Generic;
using System.Linq;

namespace Basket.Offer
{
    public class TwoButtersHalfPriceBreadOffer : IOffer
    {
        public decimal GetDiscount(IReadOnlyCollection<Product> products)
        {
            // 4 Butter will not make 2 breads 50% discounted, but that is not explicit requirement
            // Can be implemented if the requirement is clarified
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
