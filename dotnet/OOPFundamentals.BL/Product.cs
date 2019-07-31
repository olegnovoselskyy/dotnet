using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductID = productId;            
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            // Code that retrieves the defined product

            return new Product();
        }

        /// <summary>
        /// Retrieve all products.
        /// </summary>
        public List<Product> Retrieve()
        {
            // Code that retrieves all of the products

            return new List<Product>();
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the current product

            return true;
        }

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
