using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PopulationCounter
{
    static void Main(string[] args)
    {

        // Create dictionary as Dictionary<country, Dictionary<city, count>>
        var populations = new Dictionary<string, Dictionary<string, long>>();

        // Take the input as string array
        string[] input = Console.ReadLine().Split('|');

        while (!input[0].Equals("report"))
        {
            // take different parameters from input
            string country = input[1];
            string city = input[0];
            long count = long.Parse(input[2]);

            if (!populations.ContainsKey(country))
            {
                populations.Add(country, new Dictionary<string, long>());
                populations[country].Add("total", 0);
            }
            populations[country].Add(city, count);
            populations[country]["total"] += count;
                      
            input = Console.ReadLine().Split('|');
        }


        var sorted = populations
            .OrderByDescending(x => x.Value["total"])
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var state in sorted.Keys)
        {
            Console.WriteLine($"{state} (total population: {sorted[state]["total"]})");

            foreach (var town in sorted[state].OrderByDescending(t => t.Value))
            {
                if (!town.Key.Equals("total"))
                {
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
                }
                
            }
        }
        Console.WriteLine();
    }
}

