# 'out' Deep dive

This project demonstrates how to use `out` keyword with different aspects,

In C# using 'out' keyword is indicating that the parameter is passed by reference rather than value, that means, any changes made to the parameter will be made available outside of the method.

The other purpose of using out is, we can return multiple parameters from a method, this might be very useful in cases where we need multiple values to be evaluated in the caller function.

We will see how this is happening!

