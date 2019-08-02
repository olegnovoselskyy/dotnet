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
        public int ShippingAddressID { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int OrderItemCount { get; set; }

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
