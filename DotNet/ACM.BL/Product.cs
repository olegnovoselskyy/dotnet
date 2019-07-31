using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
    {
        #region Properties

        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? Price { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Validates the product data, All properties required.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName) || string.IsNullOrWhiteSpace(ProductDescription))
                isValid = false;

            if (Price == null)
                isValid = false;

            return isValid;
        }

        /// <summary>
        /// Saves the product data
        /// </summary>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Loads one product based on ProductID
        /// </summary>
        public Product Load(int productId)
        {
            return new Product();
        }

        /// <summary>
        /// Loads all products
        /// </summary>
        public List<Product> LoadAll()
        {
            return new List<Product>();
        }


        #endregion
    }
}
