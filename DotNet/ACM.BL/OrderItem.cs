using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        #region Properties

        public int OrderItemID { get; private set; }
        public int OrderID { get; private set; }
        public int ProductID { get; private set; }
        public decimal PurchasePrice { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Validates the order item data
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            return isValid;
        }

        /// <summary>
        /// Saves the order item data
        /// </summary>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Loads all order items based on OrderID
        /// </summary>
        public OrderItem Load(int orderId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Loads all order items
        /// </summary>
        public List<OrderItem> LoadAll()
        {
            return new List<OrderItem>();
        }


        #endregion
    }
}
