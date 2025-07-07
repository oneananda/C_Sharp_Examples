# Dynamic Interview Q&A

# A collection of interview questions and answers focused on the `dynamic` type in C#.

1) What is the `dynamic` type in C#?

The `dynamic` type in C# is a type that bypasses compile-time type checking. It allows for late binding, meaning that method calls and property accesses are resolved at runtime rather than at compile time. This enables more flexible and dynamic programming patterns, such as working with COM objects, dynamic languages, or JSON data.

2) How does `dynamic` differ from `var` in C#?

The `var` keyword in C# is used for implicit typing, where the type is determined at compile time based on the assigned value. In contrast, `dynamic` allows for late binding, meaning the type is resolved at runtime. This means that with `var`, you get compile-time type safety and IntelliSense support, while `dynamic` does not provide these guarantees.


