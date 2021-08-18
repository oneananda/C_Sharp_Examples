// Program to convert the list of string to CSV with quotes

static void Main(string[] args)

{

 List<string> LstCities = new List<string>();

 LstCities.Add("Sydney");

LstCities.Add("Singapore");

LstCities.Add("Tokyo");

LstCities.Add("Jakarta");  


string InClause = string.Format("'{0}'", string.Join("','", LstCities));

Console.WriteLine(InClause);

Console.ReadLine();

} 
