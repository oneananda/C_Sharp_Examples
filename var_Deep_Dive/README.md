# var Deep Dive

Welcome to the **var Deep Dive** project! This project demonstrates various usages of the `var` keyword in C#. The `var` keyword allows for implicitly typing local variables, simplifying code and making it more readable in many scenarios.

## Table of Contents

- [Introduction](#introduction)
- [Examples](#examples)
  - [Example 1: Implicit Typing for Local Variables](#example-1-implicit-typing-for-local-variables)
  - [Example 2: Anonymous Types](#example-2-anonymous-types)
  - [Example 3: Complex Object Initializations](#example-3-complex-object-initializations)
  - [Example 4: LINQ Queries](#example-4-linq-queries)
  - [Example 5: Reducing Redundancy](#example-5-reducing-redundancy)
  - [Example 6: Working with Collections](#example-6-working-with-collections)
  - [Example 7: Initialization is Mandatory](#example-7-initialization-is-mandatory)
  - [Example 8: Type Cannot Change](#example-8-type-cannot-change)
  - [Example 9: Cannot be Used as a Field Type](#example-9-cannot-be-used-as-a-field-type)
  - [Example 10: Cannot be Used with Nullable Types Directly](#example-10-cannot-be-used-with-nullable-types-directly)
  - [Example 11: Inference Only Works with Single Expressions](#example-11-inference-only-works-with-single-expressions)
- [Running the Project](#running-the-project)
- [Contributing](#contributing)
- [License](#license)

## Introduction

The `var` keyword in C# is a powerful tool that allows developers to declare local variables without explicitly specifying the type. This project explores how `var` can be used in different scenarios, such as working with anonymous types, LINQ queries, and complex object initializations.

## Examples

### Example 1: Implicit Typing for Local Variables

This example demonstrates how `var` can be used to implicitly type variables based on the assigned value.

### Example 2: Anonymous Types

`var` is essential when working with anonymous types, as you cannot explicitly name the type.

### Example 3: Complex Object Initializations

When dealing with complex objects, `var` can simplify the code by eliminating redundant type declarations.

### Example 4: LINQ Queries

`var` is commonly used in LINQ queries to handle the result sets, which can be complex types like `IEnumerable<T>`.

### Example 5: Reducing Redundancy

Using `var` helps reduce redundancy in code, making it more concise and easier to read.

### Example 6: Working with Collections

`var` can be used when iterating over collections, especially when the type of elements is complex or when the exact type is not necessary to specify.

### Example 7: Initialization is Mandatory

- **Description:** When using `var`, the variable must be initialized at the time of declaration. The compiler requires an initial value to determine the type of the variable.

### Example 8: Type Cannot Change

- **Description:** Once a variable is declared using `var`, its type is fixed and cannot change. You cannot assign a value of a different type to this variable later in the code.

### Example 9: Cannot be Used as a Field Type

- **Description:** The `var` keyword cannot be used for class-level fields or properties. It is restricted to local variables inside methods, loops, or LINQ queries.

### Example 10: Cannot be Used with Nullable Types Directly

- **Description:** Directly initializing a `var` variable with `null` will cause a compile-time error because the compiler cannot infer the type. Special care must be taken when working with nullable types.

### Example 11: Inference Only Works with Single Expressions

- **Description:** The type inference provided by `var` only works with single expressions. Complex expressions that result in multiple possible types will cause a compile-time error.

## Key points in using var

### Dynamic Typing vs. var

`var` is statically typed --> infers the type at compile time
`dynamic` is infered at runtime

`var and dynamic` can cause error if mishanlded

var (Statically Typed):

```
var myVar = "Hello";  // Compiler infers string type
myVar = 123;          // Compile-time error: Cannot convert int to string
```

dynamic (Dynamically Typed):

```
dynamic myDynamic = "Hello";
myDynamic = 123;      // No compile-time error; type changes at runtime

```

###  Scoping Rules

The scope of a variable declared with `var` is limited to the local context, such as within methods, loops, or local functions. It cannot be declared as a global or class-level field or property.

### Type Safety

Even though `var` infers types, `var` doesn't weaken type safety, it maintains type safety.


