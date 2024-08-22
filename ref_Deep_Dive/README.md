# 'ref' Deep dive

This project demonstrates how to use `ref` keyword with different aspects,

In C# using 'ref' keyword is indicating that the parameter is passed by reference rather than value, that means, any changes made to the parameter will be made available outside of the method.

The other purpose of using ref is, we can return multiple parameters from a method, this might be very useful in cases where we need multiple values to be evaluated in the caller function.

We will see how this is happening!

## Example 1: Basic implementation of 'ref'

```
            int num = 10;
            Console.WriteLine($"Before method call: {num}");

            ModifyValue(ref num);

            Console.WriteLine($"After method call: {num}");

            // Output
            // Before method call: 10
            // After method call: 20
        }
```

**Calling method**

```
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

**Calling method**

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

**Calling method**


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

**Calling method**


```
        // Method that takes a Person object by reference.
        static void ModifyPerson(ref Person p)
        {
            // Create a new Person object and assign it to the parameter.
            p = new Person { Name = "Bob" };
        }
```

### Example 4: Using ref in string 

```
            string text = "Hello";
            Console.WriteLine($"Before: {text}");

            // Pass the string by reference.
            ModifyString(ref text);

            // The string reference should point to the new string value.
            Console.WriteLine($"After: {text}");
```

**Calling method**

```
        static void ModifyString(ref string s)
        {
            // Reassign the reference to a new string instance.
            s = "World";
        }
```

**Important point to be noted:** Even though by natural the `string` is reference type, it will not hold the values across methods as it is immutable, that means everytime you are assining a new value it will start referring to a new reference pointer.


### Example 5: Using ref in Recursive Methods

```
            int number = 1;
            Console.WriteLine($"Original Number: {number}");

            IncrementRef(ref number, 5);

            Console.WriteLine($"Incremented Number: {number}");
```

**Calling method**

```
            static void IncrementRef(ref int num, int limit)
            {
                if (num < limit)
                {
                    num++;
                    IncrementRef(ref num, limit);
                }
            }
```

### Example 6: Without Using ref but achive the same functionality 

```
            List<string> LstStr = new List<string>();
            LstStr.Add("Adding string 1");
            Console.WriteLine($"Original Count: {LstStr.Count}");

            ProcessLstStr(LstStr);

            Console.WriteLine($"Current Count: {LstStr.Count}");
```

**Calling method**

```
            private static void ProcessLstStr(List<string> lstStr)
            {
                // Adding values, but not returning
                lstStr.Add("Adding new string");
                lstStr.Add("Adding another new string");
            }
```

### Example 7: With and without Using ref - Performance considerations

**Without ref**

```
            LargeStruct largeStruct = new LargeStruct(1000000);
            Console.WriteLine("Starting Without ref...");

            for (int i = 0; i < 1000; i++)
            {
                ProcessLargeStruct(largeStruct);
            }

            Console.WriteLine("Finished Without ref.");
```

**Calling method**

```
        static void ProcessLargeStruct(LargeStruct ls)
        {
            // Processing large struct...
            ls.Data[0] = 42; // Modify just to simulate some processing
        }
```

**Performance Considerations:**

- **Copying:** Each time `ProcessLargeStruct` is called, a `full copy of largeStruct is made`. If the struct is large (e.g., contains a large array), this copying process can be `slow and memory-intensive`.
- **Complexity:** The overhead increases with the size of the struct and the number of times the method is called, as more time and memory are required to create and manage the copies.

**With ref**

```
            LargeStruct largeStruct = new LargeStruct(1000000);
            Console.WriteLine("Starting With ref...");

            for (int i = 0; i < 1000; i++)
            {
                ProcessLargeStruct(ref largeStruct);
            }

            Console.WriteLine("Finished With ref.");
```

**Calling method**

```
        static void ProcessLargeStruct(ref LargeStruct ls)
        {
            // Processing large struct...
            ls.Data[0] = 42; // Modify just to simulate some processing
        }
```

**Performance Considerations:**

- No Copying: By passing the struct with ref, no copying occurs. The method operates directly on the original struct, significantly reducing the time and memory overhead.
- Direct Access: Since the struct is passed by reference, any modifications made within the method are applied directly to the original struct, which can be more efficient.

**Performance Comparison Summary**

__Memory Usage & Execution Time:__

- **Without ref:** Memory usage and Execution Time increases due to the creation of multiple copies of the large struct.
- **With ref:** Memory usage and Execution Time are reduced as no copies are made; the method operates directly on the original struct.


### Key Points

**Parameter Initialization:** The parameter passed to a method with ref must be initialized before being passed to the method. If not initialized, the compiler will throw an error.

**Consistent Usage:** You must use the ref keyword both in the method definition and when calling the method. Omitting ref in either place will result in a compilation error.

**Reference:** Using ref allows you to modify the value of the argument in the caller's scope, which is different from passing parameters by value, where the method works with a copy of the argument.