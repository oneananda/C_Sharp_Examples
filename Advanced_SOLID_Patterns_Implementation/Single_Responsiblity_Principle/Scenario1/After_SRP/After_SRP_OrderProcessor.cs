using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsiblity_Principle.Scenario1.After_SRP
{
    public class After_SRP_OrderProcessor
    {
        private readonly OrderValidator _orderValidator;
        private readonly PaymentProcessor _paymentProcessor;
        private readonly InventoryManager _inventoryManager;
        private readonly EmailService _emailService;

        public After_SRP_OrderProcessor(OrderValidator orderValidator, PaymentProcessor paymentProcessor, InventoryManager inventoryManager, EmailService emailService)
        {
            _orderValidator = orderValidator;
            _paymentProcessor = paymentProcessor;
            _inventoryManager = inventoryManager;
            _emailService = emailService;
        }

        public void ProcessOrder(Order order)
        {
            _orderValidator.Validate(order);
            _paymentProcessor.ProcessPayment(order);
            _inventoryManager.UpdateInventory(order);
            _emailService.SendOrderConfirmationEmail(order);
        }
    }

    public class OrderValidator
    {
        public void Validate(Order order)
        {
            // Code to validate the order
        }
    }

    public class PaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            // Code to process payment
        }
    }

    public class InventoryManager
    {
        public void UpdateInventory(Order order)
        {
            // Code to update inventory
        }
    }

    public class EmailService
    {
        public void SendOrderConfirmationEmail(Order order)
        {
            // Code to send order confirmation email
        }
    } 

}
