using System.Collections.Generic;
using System.Linq;
using Basket.Offer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basket.Test
{
    [TestClass]
    public class BasketTests
    {
        [TestMethod]
        public void GivenButterProduct_WhenAddedToBasket_ThenItShouldBeInBasket()
        {
            //Arrange
            var basket = new Basket(null);
            var butter = StaticProductCatalog.Butter;

            //Act
            basket.AddProduct(butter);

            //Assert
            Assert.AreEqual(1, basket.Items.Count);
            Assert.IsTrue(basket.Items.Contains(butter));
        }

        [TestMethod]
        public void GivenTwoProducts_WhenAddedToBasket_ThenBasketContainsThem()
        {
            //Arrange
            var basket = new Basket(null);
            var butter = StaticProductCatalog.Butter;
            var milk = StaticProductCatalog.Milk;

            //Act
            basket.AddProduct(butter);
            basket.AddProduct(milk);

            //Assert
            Assert.AreEqual(2, basket.Items.Count);
            Assert.IsTrue(basket.Items.Contains(butter));
            Assert.IsTrue(basket.Items.Contains(milk));
        }

        [TestMethod]
        public void GivenEmptyBasket_WhenNothingIsAdded_ThenBasketHasZeroItems()
        {
            //Arrange
            var basket = new Basket(null);

            //Act

            //Assert
            Assert.AreEqual(0, basket.Items.Count);
        }

        [TestMethod]
        public void GivenBreadProduct_WhenAddedTwiceToBasket_ThenBasketShoudHaveTwoBreads()
        {
            //Arrange
            var basket = new Basket(null);
            var bread = StaticProductCatalog.Bread;

            //Act
            basket.AddProduct(bread);
            basket.AddProduct(bread);

            //Assert
            Assert.AreEqual(2, basket.Items.Count);
            Assert.IsTrue(basket.Items.All(t => t == bread));
        }

        [TestMethod]
        public void GivenBasketWithBread_WhenTotalCalculated_ThenTotalShouldBeThePriceOfBread()
        {
            //Arrange
            var basket = new Basket(new List<IOffer>());
            var bread = StaticProductCatalog.Bread;
            basket.AddProduct(bread);

            //Act
            var total = basket.GetTotal();

            //Assert
            Assert.AreEqual(bread.Price, total);
        }

        [TestMethod]
        public void GivenBasketWithBreadAndButter_WhenTotalCalculated_ThenTotalShouldBeSumOfProductPrices()
        {
            //Arrange
            var basket = new Basket(new List<IOffer>());
            var bread = StaticProductCatalog.Bread;
            var butter = StaticProductCatalog.Butter;
            basket.AddProduct(bread);
            basket.AddProduct(butter);

            //Act
            var total = basket.GetTotal();

            //Assert
            Assert.AreEqual(bread.Price + butter.Price, total);
        }

        [TestMethod]
        public void GivenBreadButterAndMilk_WhenTotalCalculated_ThenTotalShould_2_95()
        {
            //Arrange
            var basket = new Basket(new List<IOffer>());
            var bread = StaticProductCatalog.Bread;
            var butter = StaticProductCatalog.Butter;
            var milk = StaticProductCatalog.Milk;
            basket.AddProduct(bread);
            basket.AddProduct(butter);
            basket.AddProduct(milk);

            //Act
            var total = basket.GetTotal();

            //Assert
            Assert.AreEqual(2.95m, total);
        }

        [TestMethod]
        public void Given2ButterAnd2Bread_WhenTotalCalculated_ThenTotalShould_3_10()
        {
            //Arrange
            var basket = new Basket(new List<IOffer> { new TwoButtersHalfPriceBreadOffer() });
            basket.AddProduct(StaticProductCatalog.Butter);
            basket.AddProduct(StaticProductCatalog.Butter);
            basket.AddProduct(StaticProductCatalog.Bread);
            basket.AddProduct(StaticProductCatalog.Bread);

            //Act
            var total = basket.GetTotal();

            //Assert
            Assert.AreEqual(3.10m, total);
        }

        [TestMethod]
        public void Given4Milks_WhenTotalCalculated_ThenTotalShould_3_45()
        {
            //Arrange
            var basket = new Basket(new List<IOffer> { new ThreeMilkGetFourthForFreeOffer() });
            basket.AddProduct(StaticProductCatalog.Milk);
            basket.AddProduct(StaticProductCatalog.Milk);
            basket.AddProduct(StaticProductCatalog.Milk);
            basket.AddProduct(StaticProductCatalog.Milk);

            //Act
            var total = basket.GetTotal();

            //Assert
            Assert.AreEqual(3.45m, total);
        }
    }
}
