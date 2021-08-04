        static void Main(string[] args)
        {
            Console.WriteLine(CheckIsPangram("The quick brown fox jumps over the lazy dog"));
            Console.WriteLine(CheckIsPangram("The quick brown fo"));
            Console.ReadLine();
        }
        public static bool CheckIsPangram(string str)
        {
            List<string> LstAtoZ =
                               Enumerable.Range('A', 26)
                              .Select(x => (char)x + "")
                              .ToList();           

            str = str.Replace(" ", "");

            foreach (char chr in str)
            {
                if (LstAtoZ.Contains(chr.ToString().ToUpper()))
                {
                    LstAtoZ.Remove(chr.ToString().ToUpper());
                }
            }

            return LstAtoZ.Count() == 0 ? true : false;
        }
