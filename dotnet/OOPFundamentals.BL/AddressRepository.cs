using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address.
        /// </summary>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address class
            // Pass in the requested id
            Address address = new Address(addressId);

            // Code that retrieves the defined address

            // Temporary hard-coded values to return
            // a populated address
            if (addressId == 1)
            {
                address.AddressTypeID = 1;
                address.Street1 = "4 Privet Drive";
                address.Street2 = "";
                address.City = "Little Whinging";
                address.State = "Surrey";
                address.Country = "Great Britain";
                address.PostalCode = "7";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined addresses
            // for the customer.

            // Temporary hard-coded values to return
            // a set of Addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressTypeID = 1,
                Street1 = "4 Privet Drive",
                Street2 = "",
                City = "Little Whinging",
                State = "Surrey",
                Country = "Great Britain",
                PostalCode = "7"
            };
            addressList.Add(address);

            Address address2 = new Address(1)
            {
                AddressTypeID = 1,
                Street1 = "5 Privet Drive",
                Street2 = "",
                City = "Little Whinging",
                State = "Surrey",
                Country = "Great Britain",
                PostalCode = "7"
            };
            addressList.Add(address2);

            return addressList;
        }

        /// <summary>
        /// Saves the current address.
        /// </summary>
        public bool Save(Address address)
        {
            // Code that saves the passed in customer

            return true;
        }
    }
}
