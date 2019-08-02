using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class CustomerAddress
    {
        public CustomerAddress()
        {

        }

        public CustomerAddress(int addressId)
        {
            AddressID = addressId;
        }
        #region Properties

        public int AddressID { get; private set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string AddressType { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Validate the address data
        /// </summary>
        /// <returns></returns>
        public bool Vaildate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Street1) || string.IsNullOrWhiteSpace(City) || string.IsNullOrWhiteSpace(State)
                || string.IsNullOrWhiteSpace(Zip) || string.IsNullOrWhiteSpace(Country))
                isValid = false;

            return isValid;
        }

        #endregion
    }
}
