// Primary_Constructors reduce the boiler plate code by allowing the construtors to be defined in the class definition itself.

public class Customer(string name, int id)
{
    public string Name { get; } = name;
    public int Id { get; } = id;
}
// To instantiate 

var customer1 = new Customer("New_Cust_1",200);
