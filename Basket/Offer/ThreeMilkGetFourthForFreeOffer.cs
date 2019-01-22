using System.Collections.Generic;
using System.Linq;

namespace Basket.Offer
{
    public class ThreeMilkGetFourthForFreeOffer : IOffer
    {
        public decimal GetDiscount(IReadOnlyCollection<Product> products)
        {
            if (products.Count(t => t.Name == StaticProductCatalog.Milk.Name) > 3)
            {
                var freeMilkCount = products.Count(t => t.Name == StaticProductCatalog.Milk.Name) / 4;
                return StaticProductCatalog.Milk.Price * freeMilkCount;
            }
            return 0;
        }
    }
}
