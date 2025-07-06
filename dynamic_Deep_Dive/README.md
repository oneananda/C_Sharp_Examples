# Dynamic Deep Dive

A hands-on exploration of C#'s `dynamic` type, covering basics, intermediate, advanced, and real-world usage. This project demonstrates how dynamic typing can be leveraged in C# for flexible, runtime-resolved operations, and how it integrates with features like LINQ and dynamic objects.

## Project Structure

- **01-Basics**: Introduction to `dynamic` in C#. Shows basic dynamic typing, differences between `var` and `dynamic`, runtime method calls, and use of `ExpandoObject`.
- **02-Medium**: Intermediate scenarios using `dynamic`, such as working with reflection, dynamic method invocation, and interoperability.
- **03-Advanced**: Advanced use cases, including dynamic LINQ queries (using [System.Linq.Dynamic.Core](https://github.com/StefH/System.Linq.Dynamic.Core)), and more complex runtime behaviors.
- **04-RealWorld**: Practical, real-world examples where `dynamic` is useful, such as working with JSON, COM objects, or scripting.

## Requirements

- .NET 8 SDK or later
- Visual Studio 2022 or later

---

## ✅ `dynamic` vs `var` vs `object`

| Feature                      | `var`                  | `object`                    | `dynamic`                                   |
| ---------------------------- | ---------------------- | --------------------------- | ------------------------------------------- |
| **Type Binding**             | Compile-time           | Compile-time (casts needed) | **Runtime (late binding)**                  |
| **Compile-time Type Safety** | ✅ Yes                  | ✅ Yes                       | ❌ No — runtime only                         |
| **IntelliSense Support**     | ✅ Yes                  | ✅ Limited                   | ❌ Not available (no compile-time type info) |
| **Method Resolution**        | At compile-time        | Requires casting            | **At runtime — flexible**                   |
| **Performance**              | High (static dispatch) | Medium (boxing/unboxing)    | ❌ Slower (runtime binder)                   |
| **Use Cases**                | Known types            | General-purpose containers  | **Unknown/variable types at runtime**       |
| **Reflection Alternative**   | ❌                      | ✅ (but verbose)             | ✅ **Simpler than reflection**               |
| **Interop Friendly**         | ❌                      | ✅ With casting              | ✅ **Ideal for COM, scripting, JSON**        |

---

## 🔍 What's **Unique** About `dynamic`?

### 1. **Runtime Method & Property Resolution (Late Binding)**

```csharp
dynamic obj = "Hello World";
Console.WriteLine(obj.ToUpper());  // Works even though compiler doesn't know obj is a string
```

* The method is resolved **at runtime**.
* If it doesn’t exist, you'll get a `RuntimeBinderException`.

---

### 2. **Eliminates the Need for Casting or Reflection**

```csharp
object obj = "hello";
// Console.WriteLine(obj.ToUpper()); // ❌ Compile-time error
Console.WriteLine(((string)obj).ToUpper()); // ✅

dynamic dyn = "hello";
Console.WriteLine(dyn.ToUpper()); // ✅ No cast needed
```

---


