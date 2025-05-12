// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(String[] args)
    {
        var numbers = new[] { 1, 6, 8, 9, 3, 74, 9 };
        bool isAnyNumberLargerThan10 = numbers.Any(
            number => number > 10
        );
        Console.WriteLine(isAnyNumberLargerThan10);
        Console.ReadKey();
    }
}
