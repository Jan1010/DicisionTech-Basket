using System;
using System.Collections.Generic;
using System.Text;
using Basket.Offer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basket.Test.Offer
{
    [TestClass]
    public class ThreeMilkGetFourthForFreeOfferTests
    {
        [TestMethod]
        public void Given4Milks_WhenDiscountRequested_ThenDiscountShouldBeOneMilk()
        {
            //Arrange
            ThreeMilkGetFourthForFreeOffer offer = new ThreeMilkGetFourthForFreeOffer();
            List<Product> products = new List<Product>
            {
                StaticProductCatalog.Milk,
                StaticProductCatalog.Milk,
                StaticProductCatalog.Milk,
                StaticProductCatalog.Milk,
            };

            //Act
            var discount = offer.GetDiscount(products);

            //Assert
            Assert.AreEqual(StaticProductCatalog.Milk.Price, discount);
        }

        [TestMethod]
        public void Given8Milks_WhenDiscountRequested_ThenDiscountShouldBeTwoMilks()
        {
            //Arrange
            ThreeMilkGetFourthForFreeOffer offer = new ThreeMilkGetFourthForFreeOffer();
            List<Product> products = new List<Product>
            {
                StaticProductCatalog.Milk,
                StaticProductCatalog.Milk,
                StaticProductCatalog.Milk,
                StaticProductCatalog.Milk,
                StaticProductCatalog.Milk,
                StaticProductCatalog.Milk,
                StaticProductCatalog.Milk,
                StaticProductCatalog.Milk,
            };

            //Act
            var discount = offer.GetDiscount(products);

            //Assert
            Assert.AreEqual(StaticProductCatalog.Milk.Price * 2, discount);
        }
    }
}
