﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPFundamentals.BL;

namespace OOPFundamentals.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Dima",
                LastName = "Lytvyn"
            };
            string expected = "Lytvyn, Dima";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Mac",
            };
            string expected = "Mac";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            Customer R = new Customer();
            R.FirstName = "Rob";
            R.LastName = "Smitha";
            Customer.InstanceCount++;

            Customer O = new Customer();
            O.FirstName = "Oleg";
            O.LastName = "Novoselskyy";
            Customer.InstanceCount++;

            Customer D = new Customer();
            D.FirstName = "Dima";
            D.LastName = "Lytvyn";
            Customer.InstanceCount++;

            int expected = 3;

            //--Act
            int actual = Customer.InstanceCount;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                LastName = "Sogluizzo",
                EmailAddress = "zakkscott1@gmail.com"
            };
            bool expected = true;

            //--Act
            bool actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--Arrange
            Customer customer = new Customer
            {
                EmailAddress = "lytproduct@gmail.com"
            };
            bool expected = false;

            //--Act
            bool actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
}