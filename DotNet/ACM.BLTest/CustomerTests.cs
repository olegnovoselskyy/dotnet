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

            var expectedResult = "Oleg Novo";

            //Act
            var actualResult = customer.FullName;

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Novo";

            var expectedResult = " Novo";

            //Act
            var actualResult = customer.FullName;

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Oleg";

            var expectedResult = "Oleg ";

            //Act
            var actualResult = customer.FullName;

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
