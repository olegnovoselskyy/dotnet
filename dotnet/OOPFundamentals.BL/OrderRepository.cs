using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Order class
            // Pass in the requested id
            Order order = new Order(orderId);

            // Code that retrieves the defined order

            // Temporary hard-coded values to return
            // a populated order
            if (orderId == 1)
            {
                order.CustomerID = 1;
                order.OrderDate = DateTime.Now;
                order.OrderItemCount = 1;
            }
            return order;
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        public bool Save(Order order)
        {
            // Code that saves the passed in order

            return true;
        }
    }
}
