using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.BL
{
    public class Order
    {
        public Order()
        {
                
        }

        public Order(int orderId)
        {
            OrderID = orderId;
        }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderItemCount { get; set; }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // Code that retrieves the defined order

            return new Order();
        }

        /// <summary>
        /// Retrieve all orders.
        /// </summary>
        public List<Order> Retrieve()
        {
            // Code that retrieves all of the orders

            return new List<Order>();
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the current order

            return true;
        }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;
            if (OrderItemCount <= 0 || OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
