using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex98_PopulationCounter
{
    class PopulationCounterV2
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

                // check if country exist, if not, create key for it and total 
                // population counter initially equal to 0
                if (!populations.ContainsKey(country))
                {
                    populations.Add(country, new Dictionary<string, long>());
                    populations[country].Add("total", 0);
                }
                // from here on, fill created contry dictionary with city and
                // it's population
                populations[country].Add(city, count);
                // add this city population to country total
                populations[country]["total"] += count;

                input = Console.ReadLine().Split('|');
            }

            // Old variant with sorting only contryes. 
            // TODO: find a way to sort towns to
            // var sorted = populations
            //    .OrderByDescending(x => x.Value["total"])
            //    .ToDictionary(x => x.Key, x => x.Value);

            // printing the result
            // select outer dictionary for countryes and sort them
            // according (OuterDict.Value)["total"]
            // (OuterDict.Value) is pointing to every one of inner dictionaryes
            // and ["total"] takes out contryes population
            foreach (var state in populations.OrderByDescending(s => s.Value["total"]))
            {
                Console.WriteLine($"{state.Key} (total population: {state.Value["total"]})");

                // the same procedure for inner dictionary
                foreach (var town in state.Value.OrderByDescending(t => t.Value))
                {
                    if (!town.Key.Equals("total"))
                    {
                        Console.WriteLine($"=>{town.Key}: {town.Value}");
                    }

                }
            }
        }
    }
}
