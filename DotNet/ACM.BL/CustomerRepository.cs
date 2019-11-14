using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {

        private AddressRepository addresses { get; set; }

        public CustomerRepository()
        {
            addresses = new AddressRepository();
        }

        /// <summary>
        /// Loads one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Load(int customerId)
        {
            var customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "olegnovo1017@gmail.com";
                customer.FirstName = "Oleg";
                customer.LastName = "Novo";
                customer.AddressList = addresses.LoadAllAddressesByCustomerID(customerId).ToList();
            }

            return customer;
        }
        /// <summary>
        /// Saves the customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            return true;
        }

    }
}
