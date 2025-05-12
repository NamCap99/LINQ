using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestC.LINQ
{
    public class Count
    {
        public static bool IsAnySequenceTooLong_Refactor(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
        {
            return numberSequences.Any(number => number.Count() > maxLength);
        }
        public static bool IsAnySequenceTooLong(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
        {
            foreach (var numberSequence in numberSequences)
            {
                var count = 0;
                foreach (var number in numberSequence)
                    ++count;
                if (count > maxLength)
                    return true;
            }
            return false;
        }

        public static void Run()
        {
            var test1 = new List<List<int>>
    {
        new List<int> { 1, 2, 3 },
        new List<int> { 4, 5 },
        new List<int> { 6, 7, 8, 9 }
    };

            var test2 = new List<List<int>>
    {
        new List<int> { 10 },
        new List<int> { 20, 30 },
        new List<int> { 40, 50, 60 }
    };

            var test3 = new List<List<int>>();  // empty outer list

            int maxLength = 3;

            Console.WriteLine("Test 1 (Has a sequence longer than 3): " + IsAnySequenceTooLong_Refactor(test1, maxLength)); // ✅ true
            Console.WriteLine("Test 2 (All sequences <= 3): " + IsAnySequenceTooLong_Refactor(test2, maxLength));          // ❌ false
            Console.WriteLine("Test 3 (Empty list): " + IsAnySequenceTooLong_Refactor(test3, maxLength));                 // ❌ false
        }

    }
}