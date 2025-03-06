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
            string decoded = Decode(encoded);

            Console.WriteLine($"Original: {input}");
            Console.WriteLine($"Encoded: {encoded}");
            Console.WriteLine($"Decoded: {decoded}");
        }

        public static string Decode(string encoded)
        {
            if (string.IsNullOrEmpty(encoded))
                return "";

            StringBuilder decoded = new StringBuilder();

            for (int i = 0; i < encoded.Length; i += 2)
            {
                char character = encoded[i];
                int count = int.Parse(encoded[i + 1].ToString());

                decoded.Append(character, count);
            }

            return decoded.ToString();
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
