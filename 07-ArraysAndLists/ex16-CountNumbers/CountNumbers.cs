using System;
using System.Collections.Generic;
using System.Linq;

namespace ex16_CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            byte option = 0;

            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();

            switch (option)
            {
                case 0: CountingOccurrencesUsingArray(input); break;
                case 1: CountingOccurencesByAfterSorting(input); break;
                case 2: CountingOccurrencesWithDictionary(input); break;
                default:
                    break;
            }
        }

        static void CountingOccurrencesUsingArray(List<int> nums)
        {
            int[] counts = new int[nums.Max() + 1];

            foreach (var num in nums)
            {
                counts[num]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] != 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}" );
                }
            }
        }

        static void CountingOccurencesByAfterSorting(List<int> nums)
        {
            int count = 1;
            for (int i = 0; i < nums.Count; i++)
            {
                
                if (i == nums.Count -1 || nums[i] != nums[i+1])
                {
                    Console.WriteLine($"{nums[i]} -> {count}");
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
        }

        static void CountingOccurrencesWithDictionary(List<int> nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach(var num in nums)
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

            foreach (var i in counts.Keys.OrderBy(x => x))
            {
                Console.WriteLine($"{i} -> {counts[i]}");
            }

        }
    }
}
