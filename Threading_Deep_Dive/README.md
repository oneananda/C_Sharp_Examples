# Threading Deep Dive

## Program #1 - EnterScope_Example

**Key points:**

1. Lock is a new type in .NET 9 / C# 13 (in System.Threading).


2. EnterScope() → returns a disposable struct (Lock.Scope) that automatically releases when leaving scope (using/await using).


3. Unlike Monitor, no risk of forgetting Exit(). Safer, shorter, and exception-proof.


4. The lock keyword has been updated:

lock (_lock)
{
    _counter++;
}