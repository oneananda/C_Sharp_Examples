
// LINQ - ToLookup Examples - OneAnanda

// ToLookup will group items based on the condition

using System.Diagnostics.Metrics;

string[] countries = { "USA", "Canada", "UK", "India", "Australia", "Germany", "France" };

// Here we are grouping the List of string based on first letter
var lookup = countries.ToLookup(c => c[0]);

FileStream fs = new FileStream("Output.txt", FileMode.Create);
StreamWriter sw = new StreamWriter(fs);

Console.SetOut(sw);

// Execution 1

foreach (var group in lookup)
{
    // group.Key is the result for the condition provided
    // Say for example : U, C, I, A, G, F are the keys
    Console.WriteLine($"Countries starting with {group.Key}:");
    foreach (var country in group)
    {
        Console.WriteLine(country);
    }
}



/*
 
Output 1
 
Countries starting with U:
USA
UK
Countries starting with C:
Canada
Countries starting with I:
India
Countries starting with A:
Australia
Countries starting with G:
Germany
Countries starting with F:
France

*/

Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);


// Execution 2

// Take a student example 

var students = new[]
        {
            new { Name = "Student 1", Age = 20 },
            new { Name = "Student 2", Age = 21 },
            new { Name = "Student 3", Age = 20 },
            new { Name = "Student 4", Age = 22 },
            new { Name = "Student 5", Age = 21 },
            new { Name = "Student 6", Age = 22 }
        };


// Create a Lookup of students by their age
var ageLookup = students.ToLookup(s => s.Age);

foreach (var ageGroup in ageLookup)
{
    Console.WriteLine($"Students with the age {ageGroup.Key}:");
    foreach (var student in ageGroup)
    {
        Console.WriteLine(student.Name);
    }
}


/*

Output 2

Students with the age 20:
Student 1
Student 3
Students with the age 21:
Student 2
Student 5
Students with the age 22:
Student 4
Student 6

*/


Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);




// Execution 3

// Diving little more deeper 

// Adding Customer and Order classes and details

var customers = new List<Customer>
            {
                new Customer{ CustomerID ="C1", CustomerName= "Jack"},
                new Customer{ CustomerID ="C2", CustomerName= "John"},
            };

var orders = new List<Order>
            {
                new Order{ OrderID="O1", CustomerID ="C1", Amount = 100},
                new Order{ OrderID="O2", CustomerID ="C1", Amount = 200},
                new Order{ OrderID="O3", CustomerID ="C2", Amount = 500},
                new Order{ OrderID="O4", CustomerID ="C2", Amount = 1500},
                new Order{ OrderID="O5", CustomerID ="C2", Amount = 800}
            };


var orderLookup = orders.ToLookup(s => s.CustomerID);



foreach (var custGroup in orderLookup)
{
    Console.WriteLine($"Details for the Customer {custGroup.Key}:");
    foreach (var customer in custGroup)
    {
        Console.WriteLine($"OrderID: {customer.OrderID} Amount: {customer.Amount}");
    }
}

/*
 Output 3

Details for the Customer C1:
OrderID: O1 Amount: 100
OrderID: O2 Amount: 200
Details for the Customer C2:
OrderID: O3 Amount: 500
OrderID: O4 Amount: 1500
OrderID: O5 Amount: 800

 */




Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);

// Digging more with the same order


var orderLookup2 = orders.ToLookup(s => s.CustomerID).Where(x=>x.Key.Contains("1"));




foreach (var custGroup in orderLookup2)
{
    Console.WriteLine($"Details for the Customer {custGroup.Key}:");
    foreach (var customer in custGroup)
    {
        Console.WriteLine($"OrderID: {customer.OrderID} Amount: {customer.Amount}");
    }
}

/*
 Output 4

Details for the Customer C1:
OrderID: O1 Amount: 100
OrderID: O2 Amount: 200

 */


sw.Close();


Console.ReadLine();


public class Customer
{
    public string CustomerID { get; set; }
    public string CustomerName { get; set; }
}
public class Order
{
    public string OrderID { get; set; }
    public string CustomerID { get; set; }
    public int Amount { get; set; }
}
