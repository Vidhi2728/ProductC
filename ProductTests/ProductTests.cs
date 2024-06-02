
using ProductC;

namespace eCommerceApp.Tests
{
    public class ProductTests
    {
        private Product _product;

        [SetUp]
        public void Setup()
        {
            // This will be used in test methods where we do not need a specific setup.
            _product = new Product(1, "TestProduct", 100, 10);
        }

        [TestCase(1)]
        [TestCase(499)]
        [TestCase(1000)]
        public void ProductID_SetToValidValue_IsValid(int productId)
        {
            // Arrange
            string productName = "TestProduct";
            decimal price = 100;
            int stock = 10;

            // Act
            var product = new Product(productId, productName, price, stock);

            // Assert
            Assert.That(product.GetProductId(), Is.EqualTo(productId));
        }
        [TestCase("TestProduct 1")]
        [TestCase("TestProduct 2")]
        [TestCase("TestProduct 3")]
        public void ProductName_SetToValidValue_IsValid(String productName)
        {
            // Arrange
            int productId = 1;
            decimal price = 100;
            int stock = 10;

            // Act
            var product = new Product(productId, productName, price, stock);

            // Assert
            Assert.That(product.GetProductName(), Is.EqualTo(productName));
        }

        

        [TestCase(1)]
        [TestCase(2600)]
        [TestCase(5000)]
        public void Price_SetToValidValue_IsValid(decimal price)
        {
            // Arrange
            int productId = 1;
            string productName = "TestProduct";
            int stock = 10;

            // Act
            var product = new Product(productId, productName, price, stock);

            // Assert
            Assert.That(product.GetPrice(), Is.EqualTo(price));
        }

        

        [TestCase(1)]
        [TestCase(499)]
        [TestCase(999)]
        public void Stock_SetToValidValue_IsValid(int stock)
        {
            // Arrange
            int productId = 1;
            string productName = "TestProduct";
            decimal price = 100;

            // Act
            var product = new Product(productId, productName, price, stock);

            // Assert
            Assert.That(product.GetStock(), Is.EqualTo(stock));
        }


        [TestCase(1)]
        [TestCase(499)]
        [TestCase(999)]
        public void IncreaseStock_ByPositiveAmount_IncreasesStock(int stock)
        {
            // Arrange
            int initialStock = _product.GetStock();
            int increaseBy = 5;

            // Act
            _product.IncreaseStock(increaseBy);

            // Assert
            Assert.That(_product.GetStock(), Is.EqualTo(initialStock + increaseBy));
        }

        


        [TestCase(1)]
        [TestCase(499)]
        [TestCase(999)]
        public void DecreaseStock_ByPositiveAmount_DecreasesStock(int stock)
        {
            // Arrange
            int initialStock = _product.GetStock();
            int decreaseBy = 5;

            // Act
            _product.DecreaseStock(decreaseBy);

            // Assert
            Assert.That(_product.GetStock(), Is.EqualTo(initialStock - decreaseBy));
        }

        
    }
}
