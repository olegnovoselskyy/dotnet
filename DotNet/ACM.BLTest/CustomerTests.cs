using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerTests
    {
        [Fact]
        public void FullNameProperty()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Oleg";
            customer.LastName = "Novo";

            //Assert
            var expectedResult = "Oleg Novo";

            //Act
            Assert.Equal(expectedResult, customer.FullName);

        }
    }
}
