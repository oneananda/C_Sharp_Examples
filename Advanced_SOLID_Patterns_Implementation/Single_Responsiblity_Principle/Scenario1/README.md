# Advanced SOLID Patterns Implementation - Single Responsibility Principle (SRP)

#### Before Applying SRP

Consider a single `Before_SRP_OrderProcessor` class that handles the entire order process:

```
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

```

In this example, the `Before_SRP_OrderProcessor` class has multiple responsibilities: validating the order, processing payment, updating inventory, and sending confirmation emails. This violates the SRP.

#### After Applying SRP


```
internal class After_SRP_User
{
    public string Name { get; set; }
    public string Email { get; set; }
}
```

```
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
```

To adhere to SRP, we can separate these responsibilities into individual classes:
