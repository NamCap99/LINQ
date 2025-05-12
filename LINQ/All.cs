using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestC.LINQ
{
    // Refactor the AreAllWordsOfTheSameLength method using LINQ
    public class All
    {
        public static bool AreAllWordsOfTheSameLength_Refactor(List<string> words)
        {
            return words.All(word => word.Length == words[0].Length);
        }
        public static bool AreAllWordsOfTheSameLength(List<string> words)
        {
            if (words.Count == 0 || words.Count == 1)
            {

                return true;
            }

            var length0 = words[0].Length;
            for (int i = 1; i < words.Count; i++)
            {
                if (words[i].Length != length0)
                {
                    return false;
                }
            }
            return true;

        }
        public static void Run()
        {
            var test1 = new List<string> { "Cat", "Dog", "Pig" };  // All length 3 → ✅ true
            var test2 = new List<string> { "Apple", "Kiwi", "Banana" };  // Different lengths → ❌ false
            var test3 = new List<string>();  // Empty list → ✅ true
            var test4 = new List<string> { "Hi" };  // Single item → ✅ true

            Console.WriteLine("Test 1 (Same length): " + AreAllWordsOfTheSameLength_Refactor(test1));
            Console.WriteLine("Test 2 (Different lengths): " + AreAllWordsOfTheSameLength_Refactor(test2));
            Console.WriteLine("Test 3 (Empty list): " + AreAllWordsOfTheSameLength_Refactor(test3));
            Console.WriteLine("Test 4 (One word): " + AreAllWordsOfTheSameLength_Refactor(test4));
        }

    }
}