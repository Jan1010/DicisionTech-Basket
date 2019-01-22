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
            var butter = new Product { Name = "butter", Price = 0.8m };

            //Act
            basket.AddProduct(butter);

            //Assert
            Assert.AreEqual(1, basket.Items.Count);
            Assert.IsTrue(basket.Items.Contains(butter));
        }
    }
}
