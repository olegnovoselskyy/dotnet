using OOPFundamentals.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerID = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerID { get; private set; }
        public int CustomerTypeID { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastName;
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

        public string Log() =>
            $"{CustomerID}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
