using System.Linq;
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
            var basket = new Basket();
            var butter = new Product { Name = "butter", Price = 0.80m };

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
            var basket = new Basket();
            var butter = new Product { Name = "butter", Price = 0.80m };
            var milk = new Product { Name = "milk", Price = 1.15m };

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
            var basket = new Basket();

            //Act

            //Assert
            Assert.AreEqual(0, basket.Items.Count);
        }

        [TestMethod]
        public void GivenBreadProduct_WhenAddedTwiceToBasket_ThenBasketShoudHaveTwoBreads()
        {
            //Arrange
            var basket = new Basket();
            var bread = new Product { Name = "bread", Price = 1.00m };

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
            var basket = new Basket();
            var bread = new Product { Name = "bread", Price = 1.00m };
            basket.AddProduct(bread);

            //Act
            var total = basket.GetTotal(basket);

            //Assert
            Assert.AreEqual(1.00m, total);
        }
    }
}
