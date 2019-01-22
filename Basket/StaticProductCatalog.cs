namespace Basket
{
    /// <summary>
    /// This class contains all available product types adn their prices
    /// </summary>
    public class StaticProductCatalog
    {
        public static Product Butter = new Product { Name = "Butter", Price = 0.80m };
        public static Product Milk = new Product { Name = "Milk", Price = 1.15m };
        public static Product Bread = new Product { Name = "Bread", Price = 1.00m };
    }
}
