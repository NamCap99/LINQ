using System;
using System.Linq;

namespace TestC.LINQ
{
    public class Any
    {
        public static bool AreAllNamesValid_Refactored(string[] names)
        {
            // Todo your code here;
            return !names.Any(name => char.IsLower(name[0]) || name.Length < 2 || name.Length > 25);
        }

        public static bool AreAllNamesValid(string[] names)
        {
            foreach (var name in names)
            {
                if (char.IsLower(name[0]))
                {
                    return false;
                }
                if (name.Length < 2)
                {
                    return false;
                }
                if (name.Length > 25)
                {
                    return false;
                }
            }
            return true;
        }

        public static void example()
        {
            string[] names = { "Nam", "Manh", "Hello Word" };
            bool result = AreAllNamesValid_Refactored(names);
            Console.WriteLine("All names valid? " + result);
        }
    }
}