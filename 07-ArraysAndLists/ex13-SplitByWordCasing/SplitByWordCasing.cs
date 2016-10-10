using System;
using System.Collections.Generic;
using System.Linq;

namespace ex13_SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[]
            { ' ', ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowercaseList = new List<string>();
            List<string> uppercaseList = new List<string>();
            List<string> mixedList = new List<string>();

            foreach (string s in input)
            {
                if (s.All(c => char.IsUpper(c)))
                {
                    uppercaseList.Add(s);
                }
                else if (s.All(c => char.IsLower(c)))
                {
                    lowercaseList.Add(s);
                }
                else
                {
                    mixedList.Add(s);
                }
            }

            Console.Write("Lower-case: " );
            Console.WriteLine(string.Join(", ", lowercaseList));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedList));
            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", uppercaseList));
        }
    }
}
