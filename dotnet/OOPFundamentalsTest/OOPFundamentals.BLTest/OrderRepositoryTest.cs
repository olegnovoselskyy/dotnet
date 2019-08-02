using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPFundamentals.BL;

namespace OOPFundamentals.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                CustomerID = 1,
                OrderDate = DateTime.Now,
                OrderItemCount = 1
            };

            //-- Act
            var actual = orderRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            //Assert.AreEqual(expected.OrderDate, actual.OrderDate); -- DateTime.Now against second DateTime.Now does not equal each other due to millisecond difference
            Assert.AreEqual(expected.OrderItemCount, actual.OrderItemCount);
        }
    }
}
