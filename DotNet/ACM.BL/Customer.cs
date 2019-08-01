using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        #region Constructors

        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerID = customerId;
        }
        #endregion

        #region Fields

        private string _firstName;
        private string _lastName;

        #endregion

        #region Properties

        public int CustomerID { get; private set; }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName))
                {
                    return LastName;
                }
                else if (string.IsNullOrWhiteSpace(LastName))
                {
                    return FirstName;
                }
                else
                {
                    return FirstName + " " + LastName;
                }
            }
        }

        public static int InstanceCount { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Validates the customer data, LastName and Email required.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress))
                isValid = false;

            return isValid;
        }     

        /// <summary>
        /// Loads all customers
        /// </summary>
        /// <returns>
        /// Returns a list of customers
        /// </returns>
        public List<Customer> LoadAll()
        {
            return new List<Customer>();
        }


        #endregion

    }
}
