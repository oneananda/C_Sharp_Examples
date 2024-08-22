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