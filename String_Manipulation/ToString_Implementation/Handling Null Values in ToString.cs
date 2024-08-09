using System;

class Product
{
    public string Name { get; set; }
    public decimal? Price { get; set; }

    // Customize ToString() implementations to handle null values gracefully,
    // avoiding exceptions.

    public override string ToString()
    {
        return $"{Name ?? "Unknown Product"} costs {(Price.HasValue ? Price.Value.ToString("C") : "N/A")}";
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product { Name = "Laptop", Price = null };
        Console.WriteLine(product.ToString()); // Outputs: Laptop costs N/A
    }
}
