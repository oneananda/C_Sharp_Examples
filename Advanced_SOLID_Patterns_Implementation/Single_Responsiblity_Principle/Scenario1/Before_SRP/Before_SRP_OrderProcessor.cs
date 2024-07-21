using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsiblity_Principle.Scenario1.Before_SRP
{
    public class Before_SRP_OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            ValidateOrder(order);
            ProcessPayment(order);
            UpdateInventory(order);
            SendOrderConfirmationEmail(order);
        }

        private void ValidateOrder(Order order)
        {
            // Code to validate the order
        }

        private void ProcessPayment(Order order)
        {
            // Code to process payment
        }

        private void UpdateInventory(Order order)
        {
            // Code to update inventory
        }

        private void SendOrderConfirmationEmail(Order order)
        {
            // Code to send order confirmation email
        }
    }

}
