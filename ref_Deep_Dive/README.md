# 'ref' Deep dive

This project demonstrates how to use `ref` keyword with different aspects,

'ref' is indicating that the parameter is passed by reference rather than value, that means, any changes made to the parameter will be made available outside of the method.

We will see how this is happening!

## Example 1: Basic implementation of 'ref'

```
        static void Main(string[] args)
        {
            #region Example 1: Basic implementation of 'ref'
            // Basic implementation of 'ref'
            int num = 10;
            Console.WriteLine($"Before method call: {num}");

            ModifyValue(ref num);

            Console.WriteLine($"After method call: {num}");

            // Output
            // Before method call: 10
            // After method call: 20
            #endregion



            Console.ReadLine();
        }

        static void ModifyValue(ref int x)
        {
            x = x * 2;
        }
```


## Example 2: Multiple 'ref' implementation

```
            int result1 = 0, result2 = 0;

            CalculateValues(5, 3, ref result1, ref result2);

            Console.WriteLine($"Sum: {result1}, Difference: {result2}");
```

```
            static void CalculateValues(int a, int b, ref int sum, ref int difference)
            {
                sum = a + b;
                difference = a - b;
            }
```

## Example 3: Handling Reference Types

```
            // Create a new Person object and set its Name property.
            Person person = new Person { Name = "Alice" };
            Console.WriteLine($"Before: {person.Name}");

            // Pass the person object by reference.
            ModifyPerson(ref person);

            // The reference to person has been changed inside the method.
            Console.WriteLine($"After: {person.Name}");

```




```
        // Method that takes a Person object by reference.
        static void ModifyPerson(ref Person p)
        {
            // Create a new Person object and assign it to the parameter.
            p = new Person { Name = "Bob" };
        }
```

## Example 3: Demonstrating String Behavior

```
            // Create a new Person object and set its Name property.
            Person person = new Person { Name = "Alice" };
            Console.WriteLine($"Before: {person.Name}");

            // Pass the person object by reference.
            ModifyPerson(ref person);

            // The reference to person has been changed inside the method.
            Console.WriteLine($"After: {person.Name}");

```




```
        // Method that takes a Person object by reference.
        static void ModifyPerson(ref Person p)
        {
            // Create a new Person object and assign it to the parameter.
            p = new Person { Name = "Bob" };
        }
```


### Key Points

**Parameter Initialization:** The parameter passed to a method with ref must be initialized before being passed to the method. If not initialized, the compiler will throw an error.

**Consistent Usage:** You must use the ref keyword both in the method definition and when calling the method. Omitting ref in either place will result in a compilation error.

**Reference Semantics:** Using ref allows you to modify the value of the argument in the caller's scope, which is different from passing parameters by value, where the method works with a copy of the argument.