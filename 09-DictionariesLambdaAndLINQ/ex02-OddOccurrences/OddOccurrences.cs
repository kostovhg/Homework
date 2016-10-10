using System;
using System.Collections.Generic;
using System.Linq;


class OddOccurrences
{
    static void Main(string[] args)
    {
        // Read line from the console ant transfer it to string array with lowercase.
        string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();

        // Create dictionary for intput to be stored as .Keys and counts as .Values
        Dictionary<string, int> counts = new Dictionary<string, int>();

        // Loop trough input members "word" and asignt "word" as .Key and appearances as .Value
        foreach (string word in input)
        {
            if (counts.ContainsKey(word) )
            {
                counts[word]++;
            }
            else
            {
                counts[word] = 1;
            }
        }

        // Create List of strings for result. 
        var results = new List<string>();

        // Loop trough Dictionary members 'pair' and check if .Value is odd. If yes, add it to List "result"
        foreach (var pair in counts)
        {
            if (pair.Value % 2 != 0)
            {
                results.Add(pair.Key);
            }
        }

        Console.WriteLine(string.Join(", ", results));

    }
}
