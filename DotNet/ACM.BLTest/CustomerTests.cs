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
            Customer.InstanceCount += 1;
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
            Customer.InstanceCount += 1;
            customer.LastName = "Novo";

            var expectedResult = "Novo";

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
            Customer.InstanceCount += 1;
            customer.FirstName = "Oleg";

            var expectedResult = "Oleg";

            //Act
            var actualResult = customer.FullName;

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void StaticInstanceCount()
        {
            //Arrange
            var customer1 = new Customer();
            Customer.InstanceCount += 1;
            var customer2 = new Customer();
            Customer.InstanceCount += 1;
            var customer3 = new Customer();
            Customer.InstanceCount += 1;
            customer1.FirstName = "Oleg";
            customer2.FirstName = "Dima";
            customer3.FirstName = "Rob";
            var expectedResult = 6; // 6 because I called it after every new Customer() in this test so far


            //Act
            var actualResult = Customer.InstanceCount;

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ValidateValidMethod()
        {
            //Arrange 
            var customerFalse = new Customer();
            customerFalse.FirstName = "Oleg";

            var customerTrue = new Customer();
            customerTrue.LastName = "Novo";
            customerTrue.EmailAddress = "oleg.novoselskyy@gmail.com";

            //Act
            var validateFalse = customerFalse.Validate();
            var validateTrue = customerTrue.Validate();

            //Assert
            Assert.False(validateFalse);
            Assert.True(validateTrue);

        }

        [Fact]
        public void CustomerIDConstructor()
        {
            //Arrange 
            var customer = new Customer(1);
            var expectedResult = 1;

            //Act
            var actualResult = customer.CustomerID;

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
