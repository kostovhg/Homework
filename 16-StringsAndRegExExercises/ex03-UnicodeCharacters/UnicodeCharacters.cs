using System;
using System.Collections.Generic;

namespace ex03_UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            List<string> output = new List<string>();

            foreach (var num in input)
            {
                output.Add(GetEscapeSequence(num));
            }

            Console.WriteLine(string.Join("", output));
        }

        public static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("x4");
        }
    }
}
