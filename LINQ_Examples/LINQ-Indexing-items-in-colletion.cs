// LINQ - Indexing items in colletion - OneAnanda


var words = new List<string>() { "apple", "banana", "carrot" };

var indexedList = words.Select((word,index)=>new {Index = index, Word = word});

foreach (var word in indexedList)
    Console.WriteLine($"{word.Index}) {word.Word}");

Console.ReadLine();

// Output 
/*

0) apple
1) banana
2) carrot

 */
