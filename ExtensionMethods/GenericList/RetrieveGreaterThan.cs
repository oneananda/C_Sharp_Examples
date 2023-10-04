
var numbers = new List<int> { 1, 4, 7, 10, 14 };
var filteredNumbers = numbers.RetrieveGreaterThan(5);

foreach (var item in filteredNumbers)
{
    Console.WriteLine(item);
}

Console.ReadLine();

public static class ListExtensions
{
    public static List<T> RetrieveGreaterThan<T>(this List<T> list, T threshold) where T : IComparable<T>
    {
        return list.Where(item => item.CompareTo(threshold) > 0).ToList();
    }
}

