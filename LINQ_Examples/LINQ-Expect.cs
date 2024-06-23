namespace LINQ_Except
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ-Expect - OneAnanda

            var list1 = new List<int>() { 1, 2, 3, 4 };

            var list2 = new List<int>() { 4, 5, 6, 7 };

            Console.WriteLine("list1 entries without the entries present in list2");

            // This will take the list1 and remove same entires present in list2
            var differenceList1 = list1.Except(list2);

            foreach (int i in differenceList1)
                Console.WriteLine(i);



            // Output

            /*
            
            1
            2
            3

             */


            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);

            // Changing to upright
            // This will take the list2 and remove same entires present in list1
            var differenceList2 = list2.Except(list1);

            Console.WriteLine("list2 entries without the entries present in list1");
            foreach (int i in differenceList2)
                Console.WriteLine(i);



            // Output

            /*
            
            5
            6
            7

             */


            Console.ReadLine();
        }
    }
}
