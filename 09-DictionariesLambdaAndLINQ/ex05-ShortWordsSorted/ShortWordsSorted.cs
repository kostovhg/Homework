using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ShortWordsSorted
{
    static void Main(string[] args)
    {
        char[] sep = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };

        List<string> words = Console.ReadLine().ToLower()
            .Split(sep, StringSplitOptions.RemoveEmptyEntries)
            .Where(word => word.Length < 5)
            .OrderBy(word => word)
            .Distinct()
            .ToList();

        Console.WriteLine(string.Join(", ", words));
    }
}

