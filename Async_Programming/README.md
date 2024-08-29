# Async Programming

In C#, async and await are used to simplify asynchronous programming. They help to write code that performs tasks asynchronously without blocking the main thread, improving responsiveness and performance.

## Overview

The project demonstrates several examples of async programming patterns:

### Examples

1. **Basic Example**:
   - Demonstrates a simple asynchronous operation alongside a regular operation.

2. **Basic Async and Await Example**:
   - Shows how to use `async` and `await` keywords to perform asynchronous tasks.

3. **Async Method Returning a Value**:
   - Demonstrates an async method that returns a value.

4. **Handling Exceptions in Async Methods**:
   - Shows how to handle exceptions that occur within asynchronous methods.

5. **Chaining Multiple Async Calls**:
   - Illustrates how to chain multiple asynchronous calls sequentially.

6. **Using `WhenAll` to Run Multiple Tasks Concurrently**:
   - Demonstrates running multiple tasks concurrently using `Task.WhenAll`.

7. **Async with Cancellation Tokens**:
   - Explains how to use cancellation tokens to manage and cancel long-running asynchronous operations.

## How to Run

1. Clone or download the repository.
2. Open the solution in your preferred IDE (e.g., Visual Studio).
3. Build the solution.
4. Run the project to see the output of each example in the console.

## Key Concepts

- **Async/Await**: Simplifies asynchronous programming by allowing developers to write code that looks synchronous but actually runs asynchronously.
- **Exception Handling**: Important in async methods to catch and handle errors that occur during asynchronous operations.
- **Task Parallelism**: The use of `Task.WhenAll` enables concurrent execution of multiple tasks, improving performance in scenarios with independent tasks.
- **Cancellation Tokens**: Provide a way to cancel long-running operations, giving the developer control over the execution of tasks.

## Dependencies

- .NET 5.0 or later
