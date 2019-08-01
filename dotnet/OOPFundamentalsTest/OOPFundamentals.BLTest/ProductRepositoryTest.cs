using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPFundamentals.BL;

namespace OOPFundamentals.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "Pocket Bot",
                Description = "A helpful friend that fits in your pocket",
                CurrentPrice = 300
            };

            //-- Act
            var actual = productRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
