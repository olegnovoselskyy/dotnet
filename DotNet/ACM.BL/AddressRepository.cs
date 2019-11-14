using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Loads one CustomerAddress
        /// </summary>
        /// <param name="CustomerAddress"></param>
        /// <returns></returns>
        public CustomerAddress Load(int addressId)
        {
            var customerAddress = new CustomerAddress(addressId);

            if (addressId == 1)
            {
                customerAddress.Street1 = "2535 Northfield Ln";
                customerAddress.City = "Clearwater";
                customerAddress.State = "FL";
                customerAddress.Zip = "33761";
                customerAddress.Country = "United States";
                customerAddress.AddressType = "Home";
            }

            return customerAddress;
        }

        public IEnumerable<CustomerAddress> LoadAllAddressesByCustomerID(int customerId)
        {
            var list = new List<CustomerAddress>();
            if (customerId == 1)
            {
                var home = new CustomerAddress
                {
                    Street1 = "2535 Northfield Ln",
                    City = "Clearwater",
                    State = "FL",
                    Zip = "33761",
                    Country = "United States",
                    AddressType = "Home"
                };

                var office = new CustomerAddress
                {
                    Street1 = "501 N Duval St",
                    City = "Tallahassee",
                    State = "FL",
                    Zip = "32303",
                    Country = "United States",
                    AddressType = "Office"
                };



                list.Add(home);
                list.Add(office);
            }           
           
            return list;
        }

        /// <summary>
        /// Saves the CustomerAddress
        /// </summary>
        /// <returns></returns>
        public bool Save(CustomerAddress customerAddress)
        {
            return true;
        }
    }
}
