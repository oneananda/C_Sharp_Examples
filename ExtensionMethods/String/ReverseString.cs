    public class StringManipulation
    {
        public void ProcessString()
        {
            string myText = "C# is fun!";
            Console.WriteLine("Whitespace removed " + myText.Reverse());
        }
    }

    public static class StringHelpers
    {
        public static string Reverse(this string wordSentence)
        {
            string reverseString = string.Empty;
            for (int i = wordSentence.Length - 1; i >= 0; i--)
            {
                reverseString += wordSentence[i];
            }
            return reverseString;
        }
    }
