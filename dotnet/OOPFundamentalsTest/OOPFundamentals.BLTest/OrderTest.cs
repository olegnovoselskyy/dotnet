using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPFundamentals.BL;

namespace OOPFundamentals.BLTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ValidateOrder()
        {
            bool OrderValid = true;
            int orderItemCount = 0;
            Customer luckyCustomer1 = new Customer
            {
                FirstName = "Ya",
                LastName = "Boi",
                EmailAddress = "yaboi@skyylyt.com"

            };
            Customer.InstanceCount++;

            Product SkyyLytGame = new Product
            {
                ProductID = 1,
                ProductName = "Pocket Pals: Adventure",
                Description = "A game for friends, with friends.",
                CurrentPrice = 20
            };

            OrderItem oi1 = new OrderItem
            {
                OrderItemID = 1,
                ProductID = SkyyLytGame.ProductID,
                Quantity = 1,
                PurchasePrice = 20
            };
            orderItemCount++;

            Order o1 = new Order
            {
                OrderID = 1,
                OrderDate = DateTime.Now,
                CustomerID = luckyCustomer1.CustomerID,
                OrderItemCount = orderItemCount
            };

            if (luckyCustomer1.Validate() && SkyyLytGame.Validate() && oi1.Validate() && o1.Validate())
            {
                OrderValid = true;
            }
            else
            {
                OrderValid = false;
            }

            var expected = true;

            var actual = OrderValid;

            Assert.AreEqual(expected, actual);
        }
    }
}
