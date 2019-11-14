using Defense.BL;
using System;
using System.Windows.Forms;

namespace Defense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            // Populate customer instance

            var order = new Order();
            // Populate order instance

            var allowSplitOrders = true;
            var emailReceipt = true;

            var payment = new Payment();
            // Populate payment info from UI

            var orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment, allowSplitOrders, emailReceipt);
        }
    }
}
