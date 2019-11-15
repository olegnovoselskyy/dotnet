using System;
using Defense.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Defense.BLTest
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValid()
        {
            // Arrange

            var customer = new Customer();
            var goalSteps = 5000;
            var actualSteps = 2000;
            var expected = 40M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            // Arrange

            var customer = new Customer();
            var goalSteps = 5000;
            var actualSteps = 5000;
            var expected = 100M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidActualIsZero()
        {
            // Arrange

            var customer = new Customer();
            var goalSteps = 5000;
            var actualSteps = 0;
            var expected = 0M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
