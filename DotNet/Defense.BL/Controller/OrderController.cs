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
        private CustomerRepository customerRepo { get; set; }
        private OrderRepository orderRepo { get; set; }
        private InventoryRepository inventoryRepo { get; set; }
        private EmailLibrary emailLibrary { get; set; }

        public OrderController()
        {
            customerRepo = new CustomerRepository();
            orderRepo = new OrderRepository();
            inventoryRepo = new InventoryRepository();
            emailLibrary = new EmailLibrary();
        }

        public void PlaceOrder(Customer customer, Order order, Payment payment, bool allowSplitOrders, bool emailReceipt)
        {
            customerRepo.Add(customer);
            orderRepo.Add(order);
            inventoryRepo.OrderItems(order, allowSplitOrders);

            payment.ProccessPayment();

            if (emailReceipt)
            {
                string message;
                var result = customer.ValidateEmail();
                if (result.Item1 == true)
                {
                    customerRepo.Update();
                    emailLibrary.SendEmail(customer.Email.Length,
                              "Here is your receipt!");
                }              
            }
        }
    }
}
