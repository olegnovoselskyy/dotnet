using OOPFundamentals.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductID = productId;            
        }

        public int ProductID { get; set; }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public override string ToString() => ProductName;

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
