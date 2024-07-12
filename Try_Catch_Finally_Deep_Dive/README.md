# C# Try Catch & Finally Demystified

One can wonder what can be there to demystify the try-catch-finally block. There are some tricky scenarios in this area. Let's see what they are:

## Overview

Ideally, `try` is used along with `catch`, so if any exception arises, it will be caught in the `catch` block. Based on the business's preference, one may want to throw the exception using the `throw` keyword, log it, or perform another action.

The `try-catch-finally` works in the following manner:

1. Control enters the `try` block.
2. If the code inside the `try` executes normally, the control goes to the `finally` block.
3. If the code inside the `try` throws an error, the contents of the `catch` block are executed, then control moves to the `finally` block.
4. In the `finally` block, the CLR will free up the resources used in that `try` block.
5. If the function returns control inside the `try` block, control will still move to the `finally` block.
6. You cannot return control from a `finally` block; if you do, you will get a compiler error: "Control cannot leave the body of a finally clause".

## Examples

### Example 1: Normal Try-Catch-Finally Block

```
static void Main(string[] args)
{
    string returnValue = GetValueFromMethod();
    Console.WriteLine(returnValue.ToString());
    Console.ReadLine();
}

private static string GetValueFromMethod()
{
    string returnValue = "Initial Value";
    try
    {
        int dividedByValue = 0;
        return returnValue;
    }
    catch (Exception ex)
    {
        // throw ex;
        return "Catch Value";
    }
    finally
    {
        // The memory will be cleared here
        returnValue = "Finally Value";
    }
}
```

***Output***

```
Initial Value
```

### Example 2: Introducing an Error

```
static void Main(string[] args)
{
    string returnValue = GetValueFromMethod();
    Console.WriteLine(returnValue.ToString());
    Console.ReadLine();
}

private static string GetValueFromMethod()
{
    string returnValue = "Initial Value";
    try
    {
        int dividedByValue = 0;
        if (100 / dividedByValue == 0)
        {
        }
        return returnValue;
    }
    catch (Exception ex)
    {
        // throw ex;
        return "Catch Value";
    }
    finally
    {
        // The memory will be cleared here
        returnValue = "Finally Value";
    }
}
```

***Output***

```
Catch Value
```

### Example 3: Assigning Values in Finally Block

## The main purpose of the finally block is to free up memory, but we can still assign values in the finally block.

```
protected static string passingValue = "Initial Value";

static void Main(string[] args)
{
    string returnValue = GetValueFromMethod();
    Console.WriteLine("Returned Value: " + returnValue.ToString());
    Console.WriteLine("Passing Value: " + passingValue);
    Console.ReadLine();
}

private static string GetValueFromMethod()
{
    try
    {
        int dividedByValue = 0;
        if (100 / dividedByValue == 0)
        {
        }
        return passingValue;
    }
    catch (Exception ex)
    {
        // throw ex;
        return "Catch Value";
    }
    finally
    {
        // The memory will be cleared here, but assigning the values here again
        passingValue = "Finally Value";
    }
}
```

***Output***

```
Returned Value: Catch Value
Passing Value: Finally Value
```

### Conclusion

## Understanding the nuances of the try-catch-finally block is crucial for robust exception handling in C#. This guide illustrates different scenarios and outcomes to help you grasp the intricate behaviors of these blocks.