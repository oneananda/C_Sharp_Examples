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

**Calling method**

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

2. **Using `out` for Multiple Return Values**  
   - Illustrates how to use the `out` keyword to return multiple values from a method, such as quotient and remainder from a division operation.

**Calling method**
 
```
            int dividend = 17, divisor = 3;
            int quotient, remainder;

            Divide(dividend, divisor, out quotient, out remainder);

            Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
```

**Out Method**

```
        static void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
```

3. **Using `out` with `TryParse`**  
   - Shows how `out` is commonly used with the `TryParse` method to convert strings to numeric types safely.

**Calling method**
 
```
            string input = "123";

            if (int.TryParse(input, out int result))
            {
                Console.WriteLine($"Parsing successful: {result}");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }
            Console.WriteLine(string.Empty);

           
            input = "123A";

            if (int.TryParse(input, out result))
            {
                Console.WriteLine($"Parsing successful: {result}");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }
```

 
4. **Method Overloading with `out`**  
   - Explores how method overloading works when methods differ by their `out` parameters, and how it can be used to provide multiple functionalities.

**Calling method**
 
```
            int overloadResult;

            DoSomething(5, out overloadResult); // Calls the first method
            Console.WriteLine(overloadResult);   // Output: 10

            DoSomething(5, 3, out overloadResult); // Calls the second method
            Console.WriteLine(overloadResult);     // Output: 8
```

**Out Method**

```
        static void DoSomething(int a, out int b)
        {
            b = a * 2;
        }
        static void DoSomething(int a, int c, out int b)
        {
            b = a + c;
        }
```

## Key Takeaways

- **Mandatory Assignment:** The `out` parameter must be assigned a value within the method before the method returns. If not, the compiler will generate an error.
- **Difference from `ref`:** Unlike `ref`, `out` parameters do not need to be initialized before passing them to a method, but they must be initialized within the method.
- **Multiple Return Values:** `out` is an excellent way to return multiple values from a method without using complex data structures.
- **Overloading Flexibility:** Method overloading with `out` parameters allows for flexible method signatures and multiple implementations.
