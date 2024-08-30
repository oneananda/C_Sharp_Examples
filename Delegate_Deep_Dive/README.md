# Delegate Deep Dive

This repository demonstrates a basic usage of delegates in C#. A delegate is a type that represents references to methods with a specific parameter list and return type. In this example, we explore how to declare, instantiate, and invoke a delegate.

## Example 1: Basic Delegate Example

### Step 1: Declare a Delegate
The first step involves declaring a delegate, which defines the signature of methods that can be referenced by the delegate.

### Step 2: Create a Method That Matches the Delegate Signature
Next, a method is created that matches the signature defined by the delegate. This method will be used later when the delegate is invoked.

### Step 3: Instantiate the Delegate
The delegate is then instantiated, and the method created in the previous step is assigned to it.

### Step 4: Invoke the Delegate
Finally, the delegate is invoked just like a method. When the delegate is called, it, in turn, calls the method assigned to it.


## Example 2: Multicast Delegate Example

### Overview
In this example, we work with a multicast delegate that can reference multiple methods. We define a delegate that accepts a message and options, then add two methods to the delegate. Both methods will be invoked when the delegate is called.

### Step 1: Declare a Delegate
The first step involves declaring a multicast delegate, which defines the signature of methods that can be referenced by the delegate. This delegate will accept two parameters: a message and options.

### Step 2: Create Methods That Match the Delegate Signature
Two methods are created that match the signature defined by the delegate. Each method handles the message and options differently based on whether options are provided.

### Step 3: Instantiate the Delegate and Add Methods
The delegate is instantiated, and one of the methods is assigned to it. The second method is then added to the delegate using the `+=` operator. This setup allows both methods to be invoked when the delegate is called.

### Step 4: Invoke the Delegate
Finally, the delegate is invoked with different messages and options. When invoked, each method added to the delegate is executed in sequence, processing the message and options according to its logic.

### Summary
This example showcases how multicast delegates can be used to invoke multiple methods with a single delegate. It highlights how we can chain methods together and handle messages and options differently in each method.

When the `MulticastDelegate()` method is called, it demonstrates the following behavior:
- Both `PrintWithOptions1` and `PrintWithOptions2` methods are executed in sequence.
- Each method processes the message and options based on its own logic.

This pattern is useful for scenarios where we need to perform multiple operations in response to a single event or action.

## Example 3: Delegate as a Parameter Example

### Overview
In this example, we work with a delegate that is passed as a parameter to a method. We define a delegate that performs mathematical operations and then pass different methods (addition and multiplication) as delegates to demonstrate how they can be used interchangeably.

### Step 1: Declare a Delegate
The first step involves declaring a delegate named `MathOperation`. This delegate defines the signature of methods that can be referenced, accepting two integers as parameters and returning an integer result.

### Step 2: Create Methods That Match the Delegate Signature
Two methods are created that match the signature defined by the delegate:
- `Add(int a, int b)`: Adds two integers and returns the result.
- `Multiply(int a, int b)`: Multiplies two integers and returns the result.

### Step 3: Use the Delegate as a Parameter
The method `PerformOperation(int a, int b, MathOperation mathOperation)` is designed to accept a `MathOperation` delegate as a parameter. Inside this method, the delegate is invoked with the provided integers, and the result is printed to the console.

### Step 4: Invoke the Methods with Different Delegates
In the `DelegateAsParameter()` method, the `PerformOperation` method is called twice:
- First, with the `Add` method as the delegate, which results in the addition of the numbers.
- Second, with the `Multiply` method as the delegate, which results in the multiplication of the numbers.

### Summary
This example showcases how delegates can be passed as parameters to methods, allowing for flexible and reusable code. By passing different methods as delegates, we can perform various operations without modifying the method that executes them.

When the `DelegateAsParameter()` method is called, it demonstrates the following behavior:
- The `Add` method is invoked through the delegate, resulting in the sum of the numbers.
- The `Multiply` method is invoked through the delegate, resulting in the product of the numbers.

This pattern is useful for scenarios where we want to perform different operations based on the method passed as a delegate, enabling greater flexibility in our code.

## Example 4 : Anonymous Method Example

### Overview
In this example, we explore the use of anonymous methods in C#. An anonymous method is a method without a name that is defined using the `delegate` keyword. We create a delegate to print messages and use an anonymous method to implement the delegate's functionality.

### Step 1: Declare a Delegate
The first step involves declaring a delegate named `PrintDelegateForAnonymous`. This delegate defines the signature of methods that can be referenced, accepting a single string parameter and returning void.

### Step 2: Create an Anonymous Method
In the `AnonymousMethod()` method, we instantiate the `PrintDelegateForAnonymous` delegate and assign it an anonymous method. The anonymous method is defined using the `delegate` keyword and prints the message passed to it.

### Step 3: Invoke the Anonymous Method
After the delegate is assigned the anonymous method, we invoke the delegate by passing a string message. The anonymous method executes, printing the message to the console.

### Summary
This example demonstrates how anonymous methods can be used to define method bodies inline, without the need to explicitly declare a separate method. Anonymous methods provide a concise way to implement delegates, especially in scenarios where the method body is small and used only once.

When the `AnonymousMethod()` method is called, it demonstrates the following behavior:
- The delegate `pda` is assigned an anonymous method that prints the message to the console.
- The delegate is invoked with the message `"Hello from an anonymous method!"`, which is then printed to the console.

This pattern is useful for scenarios where we need to define quick, short-lived methods inline, making the code more readable and reducing the overhead of defining multiple named methods.




