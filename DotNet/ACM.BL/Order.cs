using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        #region Properties

        public int OrderID { get; private set; }
        public DateTime OrderDate { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Validates the order data
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            return isValid;
        }

        /// <summary>
        /// Saves the order data
        /// </summary>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Loads one order based on OrderID
        /// </summary>
        public Order Load(int orderId)
        {
            return new Order();
        }

        /// <summary>
        /// Loads all orders
        /// </summary>
        public List<Order> LoadAll()
        {
            return new List<Order>();
        }


        #endregion
    }
}
