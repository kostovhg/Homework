using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        char[] alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();

        char[] word = Console.ReadLine().ToCharArray();

        foreach (char ch in word)
        {
            Console.WriteLine($"{ch} -> {Array.IndexOf(alphabet, ch)}");
        }
        Console.WriteLine();

    }
}
