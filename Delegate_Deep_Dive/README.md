# Delegate Deep Dive

This project demonstrates a basic usage of delegates in C#. A delegate is a type that represents references to methods with a specific parameter list and return type. In this example, we explore how to declare, instantiate, and invoke a delegate.

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

### Steps

1. **Declare a Delegate**
   We declare a delegate named `PrintWithOptionsDelegate` that takes two parameters: a message and options.

2. **Create Methods Matching the Delegate Signature**
   Two methods, `PrintWithOptions1` and `PrintWithOptions2`, are created. Both methods match the signature of the delegate and handle the message and options differently based on whether options are provided or not.

3. **Instantiate the Delegate and Add Methods**
   The delegate is instantiated and assigned to the `PrintWithOptions1` method. We then add the `PrintWithOptions2` method to the delegate using the `+=` operator. This allows both methods to be called when the delegate is invoked.

4. **Invoke the Delegate**
   The delegate is invoked with different messages and options. Each method added to the delegate will be called in the order they were added.

### Summary
This example showcases how multicast delegates can be used to invoke multiple methods with a single delegate. It highlights how we can chain methods together and handle messages and options differently in each method.

When the `MulticastDelegate()` method is called, it demonstrates the following behavior:
- Both `PrintWithOptions1` and `PrintWithOptions2` methods are executed in sequence.
- Each method processes the message and options based on its own logic.

This pattern is useful for scenarios where we need to perform multiple operations in response to a single event or action.







