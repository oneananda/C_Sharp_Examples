string myText = "C# is fun!";

int totalWords = myText.CountWords();

Console.WriteLine("Total Words " + totalWords);
Console.ReadLine();

public static class StringHelpers
{
    public static int CountWords(this string phrase)
    {
        return phrase.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
