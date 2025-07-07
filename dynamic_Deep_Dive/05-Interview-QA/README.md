# Dynamic Interview Q&A

# A collection of interview questions and answers focused on the `dynamic` type in C#.

1) What is the `dynamic` type in C#?

The `dynamic` type in C# is a type that bypasses compile-time type checking. It allows for late binding, meaning that method calls and property accesses are resolved at runtime rather than at compile time. This enables more flexible and dynamic programming patterns, such as working with COM objects, dynamic languages, or JSON data.

2) How does `dynamic` differ from `var` in C#?

The `var` keyword in C# is used for implicit typing, where the type is determined at compile time based on the assigned value. In contrast, `dynamic` allows for late binding, meaning the type is resolved at runtime. This means that with `var`, you get compile-time type safety and IntelliSense support, while `dynamic` does not provide these guarantees.

3) Can you give an example of using `dynamic` in C#?
```csharp
dynamic obj = "Hello, World!";
Console.WriteLine(obj.ToUpper()); // Outputs: HELLO, WORLD!
```

4) What are some common use cases for the `dynamic` type?
1. Interacting with COM objects or legacy APIs that do not have strong typing.
2. Working with JSON data where the structure may not be known at compile time.
3. Creating dynamic objects that can change shape at runtime, such as using `ExpandoObject`.
4. Implementing dynamic LINQ queries where the structure of the query may vary.
5. Scripting scenarios where the types of objects are not known until runtime.
6. Using dynamic languages or libraries that require late binding.

5) What are the performance implications of using `dynamic`?

Using `dynamic` can introduce performance overhead due to late binding, as method resolution occurs at runtime rather than compile time.

6) How does `dynamic` handle method resolution?
When a method is called on a `dynamic` object, the C# runtime uses a binder to resolve the method call at runtime. If the method does not exist or is not accessible, a `RuntimeBinderException` will be thrown.

7) Can you use `dynamic` with LINQ queries?
Yes, you can use `dynamic` with LINQ queries, especially when using libraries like `System.Linq.Dynamic.Core` that allow for dynamic query construction. This enables you to build queries based on runtime conditions or user input.
```csharp
using System.Linq.Dynamic.Core;
var query = dbContext.Users
	.Where("Age > 30")
	.OrderBy("Name")
	.Select("new { Name, Age }");
```

8) What are the limitations of using `dynamic`?
1. Lack of compile-time type checking, which can lead to runtime errors if methods or properties do not exist.
2. Limited IntelliSense support in IDEs, making it harder to discover available members.
3. Performance overhead due to late binding.
4. Cannot be used as a type parameter in generic types or methods.

9) How does `dynamic` interact with reflection?

`dynamic` can simplify reflection by allowing you to call methods and access properties without needing to explicitly use reflection APIs like `MethodInfo` or `PropertyInfo`.

This can make code cleaner and easier to read, but it still incurs the performance cost of late binding.
```csharp
dynamic obj = new ExpandoObject();
obj.Name = "John Doe";
Console.WriteLine(obj.Name); // Outputs: John Doe
```

10) Can you use `dynamic` with `ExpandoObject`?
Yes, `dynamic` works seamlessly with `ExpandoObject`, which allows you to create objects with properties and methods that can be added or modified at runtime.
```csharp
dynamic expando = new ExpandoObject();
expando.Name = "John";
expando.Age = 30;
Console.WriteLine($"{expando.Name} is {expando.Age} years old."); // Outputs: John is 30 years old.
```

11) How does `dynamic` handle exceptions?
When using `dynamic`, if a method or property does not exist, a `RuntimeBinderException` will be thrown at runtime. This is different from compile-time errors that would occur with statically typed code. It is important to handle these exceptions appropriately to avoid runtime crashes.
```csharp
try
{
	dynamic obj = "Hello";
	Console.WriteLine(obj.NonExistentMethod()); // This will throw RuntimeBinderException
}
catch (RuntimeBinderException ex)
{
	Console.WriteLine($"Error: {ex.Message}");
}
```