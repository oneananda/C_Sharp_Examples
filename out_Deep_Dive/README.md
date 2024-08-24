# 'out' Deep dive

This project demonstrates how to use `out` keyword with different aspects,

In C# using 'out' keyword is indicating that the parameter is passed by reference rather than value, that means, any changes made to the parameter will be made available outside of the method.

The other purpose of using out is, we can return multiple parameters from a method, this might be very useful in cases where we need multiple values to be evaluated in the caller function.

We will see how this is happening!


## Purpose

The primary objective of this project is to showcase how the `out` keyword can be utilized in different programming scenarios. This includes:

- Returning multiple values from a method.
- Handling method overloading with `out` parameters.
- Parsing strings using `TryParse` with `out`.
- Assigning values within methods using the `out` keyword.

## Examples

The project covers the following examples:

1. **Basic Example with `out` Parameter**  
   - Demonstrates how the `out` keyword can be used to return a value from a method.

```
            int x, y;
            
            y = Multiply(out x);

            Console.WriteLine($"x = {x}, y = {y}");
```

**Out Method**

```
        static int Multiply(out int a)
        {
            // The a needs to be assigned before the control leaves the method
            // if not, the compiler error will happen
            a = 10; 
            return a * a;
        } 
```

