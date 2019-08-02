using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void LoadValid()
        {
            // Arrange
            var repo = new CustomerRepository();
            var expectedResult = new Customer(1)
            {
                EmailAddress = "olegnovo1017@gmail.com",
                FirstName = "Oleg",
                LastName = "Novo"

            };

            //var ds = repo.Load(1);
            //var expectedResult = "Oleg Novo";

            // Act
            var actualResult = repo.Load(1);

            // Assert
            Assert.Equal(expectedResult.FirstName, actualResult.FirstName);
            Assert.Equal(expectedResult.LastName, actualResult.LastName);
            Assert.Equal(expectedResult.EmailAddress, actualResult.EmailAddress);
            Assert.Equal(expectedResult.FullName, actualResult.FullName);
            Assert.Equal(expectedResult.CustomerID, actualResult.CustomerID);
        }

    }
}
