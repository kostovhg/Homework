using System;
using System.Collections.Generic;
using System.Linq;

namespace ex04_Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            char[] delim = new char[] { ' ', ',', '!', '?', '.', '\t', '\n' };
            string[] input = Console.ReadLine()
                .Split(delim, StringSplitOptions.RemoveEmptyEntries);
            List<string> output = new List<string>();

            foreach (string word in input)
            {
                string inverted = string.Join("", word.ToCharArray().Reverse());
                if (word.Equals(inverted))
                {
                    output.Add(word);
                }
            }

            output = output.OrderBy(x => x).Distinct().ToList();


            Console.WriteLine(string.Join(", ", output));
        }
    }
}
