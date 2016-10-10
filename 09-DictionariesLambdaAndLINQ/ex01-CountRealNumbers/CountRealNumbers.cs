using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        double[] numbers = input.Split(' ').Select(double.Parse).ToArray();

        SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

        foreach (var num in numbers)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }

        //foreach (KeyValuePair<double, int> pair in counts)
        //{
        //    Console.WriteLine($"{pair.Key} -> {pair.Value}");
        //}

        foreach (double num in counts.Keys)
        {
            Console.WriteLine($"{num} -> {counts[num]}");
        }

    }
}

