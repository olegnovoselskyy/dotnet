using DefenseCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defense.BL
{
    public class OrderController
    {
        public void PlaceOrder(Customer customer, Order order, Payment payment, bool allowSplitOrders, bool emailReceipt)
        {
            var customerRepository = new CustomerRepository();
            customerRepository.Add(customer);

            var orderRepository = new OrderRepository();
            orderRepository.Add(order);

            var inventoryRepository = new InventoryRepository();
            inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProccessPayment();

            if (emailReceipt)
            {
                customer.ValidateEmail(customer.Email);
                customerRepository.Update();

                var email = new EmailLibrary();
                email.SendEmail(customer.Email.Length,
                                "Here is your receipt!");
            }
        }
    }
}
