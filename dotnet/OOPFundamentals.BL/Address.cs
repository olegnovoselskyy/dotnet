using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.BL
{
    public class Address : EntityBase
    {
        public Address()
        {

        }

        public Address(int addressID)
        {
            AddressID = addressID;
        }

        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public override bool Validate()
        {
            bool isValid = true;
            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
