using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemID = orderItemId;            
        }

        public int OrderItemID { get; set; }
        public int ProductID { get; set; }
        public int Quantity  { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieve one order item.
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the defined order item

            return new OrderItem();
        }

        /// <summary>
        /// Retrieve all order items.
        /// </summary>
        public List<OrderItem> Retrieve()
        {
            // Code that retrieves all of the order items

            return new List<OrderItem>();
        }

        /// <summary>
        /// Saves the current order item.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the current order item

            return true;
        }

        /// <summary>
        /// Validates the order item data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;
            if (ProductID <= 0 || PurchasePrice == null || Quantity <= 0) isValid = false;

            return isValid;
        }
    }
}
