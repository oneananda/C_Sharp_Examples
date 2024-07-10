# Implicit Conversions in C#

This repository contains examples of implicit conversions in C#. The examples range from basic to advanced scenarios, demonstrating how implicit conversions can be used in various contexts.

## Table of Contents

- [Overview](#overview)
- [Basic Examples](#basic-examples)
- [Medium Examples](#medium-examples)
- [Advanced Examples](#advanced-examples)
- [Running the Examples](#running-the-examples)
- [Contributing](#contributing)
- [License](#license)

## Overview

Implicit conversions in C# allow certain types to be converted to other types without explicit casting. This feature is useful for ensuring type safety and simplifying code. This project provides examples of implicit conversions, including numeric type conversions, class inheritance, and custom conversion operators.

## Basic level examples

**Implicit Conversion Between Numeric Types**

- Converting a smaller numeric type to a larger numeric type (e.g., `int` to `double`).
- Converting int to long
- Converting from bigger memory size to smaller one (will not compile/work)

## Medium level examples

**Implicit Conversion Between Classes**

Converting from a derived class to a base class.

In the example we can see the following things:

- Method Overloading: Allows different methods with the same name to handle various types.
- **Implicit Conversion:** The derived classes are implicitly converted to the base class Customer when needed.
- Polymorphism: The correct method is chosen based on the type of the argument passed, demonstrating polymorphism in action.

## Advanced level examples

**Custom Implicit Conversion Operators**

Creating a custom **implicit conversion** between two user-defined types.

In the example we can see the following things:

- The USD class has an implicit conversion operator that converts an EUR instance to USD.
- The EUR class has an implicit conversion operator that converts a USD instance to EUR.
- The conversion rates are hardcoded in the example (1 EUR = 1.10 USD and 1 USD = 0.91 EUR)

```
            // Convert EUR to USD
            Console.WriteLine("Convert EUR to USD");
            EUR euros = new EUR(100);
            USD dollars = euros; // You can note there is no explicit assignment
            Console.WriteLine(dollars); // Output: 110 USD
```

```
            // Convert USD to EUR
            Console.WriteLine("Convert USD to EUR");
            USD usDollars = new USD(100);
            EUR eurosFromDollars = usDollars;// You can note there is no explicit assignment
            Console.WriteLine(eurosFromDollars); // Output: 91 EUR
```