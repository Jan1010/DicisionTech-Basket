using System;
using System.Collections.Generic;
using System.Text;
using Basket.Offer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basket.Test.Offer
{
    [TestClass]
    public class TwoButtersHalfPriceBreadOfferTests
    {
        [TestMethod]
        public void Given2ButtersAnd1Bread_WhenDiscountRequested_ThenDiscountShouldBeHalfOfBread()
        {
            //Arrange
            TwoButtersHalfPriceBreadOffer offer = new TwoButtersHalfPriceBreadOffer();
            List<Product> products = new List<Product>
            {
                StaticProductCatalog.Butter,
                StaticProductCatalog.Butter,
                StaticProductCatalog.Bread,
            };

            //Act
            var discount = offer.GetDiscount(products);

            //Assert
            Assert.AreEqual(StaticProductCatalog.Bread.Price * 0.5m, discount);
        }
    }
}
