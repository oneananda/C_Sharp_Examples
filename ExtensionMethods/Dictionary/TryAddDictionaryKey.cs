using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class DictionaryManipulation
    {
        public void ProcessDictionary()
        {
            var dict = new Dictionary<int, string>();
            bool added = dict.TryAdd(1, "One");  // Returns true
            Console.WriteLine(added);
            bool addedAgain = dict.TryAdd(1, "One");  // Returns false
            Console.WriteLine(addedAgain);

            Console.ReadLine();
        }
    }
    public static class DictionaryHelpers
    {
        public static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> Dict, TKey Key, TValue Value)
        {
            bool returnValue = false;
            if (Dict != null)
            {
                if (!Dict.ContainsKey(Key))
                {
                    Dict.Add(Key, Value);
                    returnValue = true;
                }
            }
            return returnValue;
        }
    }
}
