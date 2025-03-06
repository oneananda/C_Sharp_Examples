using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Recognition_Implementation
{
    public class Run_Length_Encoding_RLE
    {
        public static void Run_Length_Encoding_RLE_Method()
        {
            string input = "AAAABBBCCDEEEE";
            string encoded = Encode(input);

            Console.WriteLine($"Original: {input}");
            Console.WriteLine($"Encoded: {encoded}");
        }

        public static string Encode(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";

            StringBuilder encoded = new StringBuilder();
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    encoded.Append(input[i - 1]);
                    encoded.Append(count);
                    count = 1;
                }
            }

            // Append the last character and count
            encoded.Append(input[^1]);
            encoded.Append(count);

            return encoded.ToString();
        }
    }
}
