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

Method Overloading: Allows different methods with the same name to handle various types.
**Implicit Conversion:** The derived classes are implicitly converted to the base class Customer when needed.
Polymorphism: The correct method is chosen based on the type of the argument passed, demonstrating polymorphism in action.

## Advanced level examples

**Custom Implicit Conversion Operators**

Creating a custom **implicit conversion** between two user-defined types.

