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
