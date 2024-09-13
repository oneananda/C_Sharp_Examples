# Factory Method Pattern in C#

This folder demonstrates the Factory Method design pattern in C#, showing both the traditional Factory Method approach and a simplified Factory Registry alternative.

## What is the Factory Method Pattern?

The Factory Method pattern is a creational design pattern that provides a way to delegate the creation of objects to subclasses. It allows you to introduce new types without modifying existing code, promoting scalability and flexibility in your application.

### Why Use the Factory Method?

- **Decoupling**: It separates the object creation logic from the business logic, making your code easier to maintain.
- **Scalability**: You can add new types without changing existing code, which adheres to the Open/Closed Principle.
- **Consistency**: It keeps the object creation consistent across your codebase.

## Example Scenarios

We have two examples here:

1. **Traditional Factory Method Pattern**: Each type of notification has its own factory class.
2. **Simplified Factory Registry**: A single factory registry manages all types, reducing the need for separate factory classes.

## 1. Traditional Factory Method Pattern

In this approach, we define a `NotificationFactory` abstract class and concrete implementations for each type of notification. This is great for larger applications where separation of concerns is critical.

### Files

- `INotification.cs`: Defines the common interface for all notifications.
- `EmailNotification.cs`, `SMSNotification.cs`, `PushNotification.cs`: Concrete notification implementations.
- `NotificationFactory.cs`: Abstract factory class with a method to create notifications.
- `EmailNotificationFactory.cs`, `SMSNotificationFactory.cs`, `PushNotificationFactory.cs`: Concrete factories that create specific types of notifications.
- `Program.cs`: Shows how to use the factories to send notifications.

### Usage

1. Clone the repository.
2. Open the solution in Visual Studio or any C# compatible IDE.
3. Run the `Program.cs` to see the notifications being sent using their respective factories.

This approach ensures loose coupling and allows you to add new notification types by creating new factory classes without altering existing code.

## 2. Simplified Factory Registry

The Factory Registry simplifies the process by using a centralized factory to manage notification creation. This approach reduces the boilerplate code and still keeps the object creation process flexible and maintainable.

### Files

- `INewNotification.cs`: The common interface for all notifications.
- `NewEmailNotification.cs`, `NewSMSNotification.cs`: Concrete notification implementations.
- `NotificationFactoryRegistry.cs`: A registry that holds factory methods for creating notifications based on a string key.
- `Program.cs`: Shows how to register and create notifications using the registry.

### Usage

Run the `Program.cs` to see how notifications are registered and created dynamically using the factory registry.

### Advantages of Factory Registry

- **Less Boilerplate**: No need for separate factory classes for each notification type.
- **Dynamic Registration**: You can add new notification types at runtime, enhancing flexibility.
- **Centralized Management**: All object creation logic is managed in one place, making it easier to maintain.

## Conclusion

Both approaches have their benefits. The traditional Factory Method pattern offers a clear, scalable structure at the cost of a bit more setup. The Factory Registry simplifies the process, which can be especially useful in smaller or more dynamic projects.

Feel free to explore both examples and choose the approach that best fits your needs. Happy coding!

