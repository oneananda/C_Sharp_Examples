using System;

public class StringManipulation
{
    public void ProcessString()
    {
        Console.WriteLine("Whitespace removed " + myText.RemoveWhiteSpaces());
    }
}

public static class StringHelpers
{
    public static string RemoveWhiteSpaces(this string sentence)
    {
        sentence = sentence.Replace(" ", string.Empty);
        return sentence;
    }
}