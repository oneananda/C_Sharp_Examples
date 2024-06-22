using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Zip_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Enumerable.Range(1, 10).ToList();

            List<string> words = numbers.Select(x => NumberToWords(x)).ToList();

            // When numbers and words count are matching!
            var zipList = numbers.Zip(words, (number, word) => new { Number = number, Word = word });

            Console.WriteLine("When numbers and words count are matching!");
            Console.WriteLine(string.Empty);

            PrintZippedValues(zipList);

            // When numbers and words count are not matching (number count is > word)
            numbers = Enumerable.Range(1, 15).ToList();

            var zipList2 = numbers.Zip(words, (number, word) => new { Number = number, Word = word });

            Console.WriteLine("When numbers and words count are not matching (number count is > word)");
            Console.WriteLine(string.Empty);

            PrintZippedValues(zipList2);


            // When numbers and words count are not matching (number count is < word)
            numbers = Enumerable.Range(1, 5).ToList();

            var zipList3 = numbers.Zip(words, (number, word) => new { Number = number, Word = word });

            Console.WriteLine("When numbers and words count are not matching (number count is < word)");
            Console.WriteLine(string.Empty);

            PrintZippedValues(zipList3);

            Console.ReadLine();
        }

        private static void PrintZippedValues(IEnumerable<dynamic> zipList)
        {
            foreach (var item in zipList)
            {
                Console.WriteLine($"{item.Number} : {item.Word}");
            }
        }

        static string NumberToWords(int number)
        {
            switch (number)
            {
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                case 10:
                    return "Ten";
                default:
                    return number.ToString();
            }
        }

    }
}
