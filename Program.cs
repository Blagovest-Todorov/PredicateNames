using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<List<string>> printNames = namesList => namesList
            .Where(el => el.Length <= length)
            .ToList()
            .ForEach(el => Console.WriteLine(el));

            printNames(names);
        }       
    }
}
