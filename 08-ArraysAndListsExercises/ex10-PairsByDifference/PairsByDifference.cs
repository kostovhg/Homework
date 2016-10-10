using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PairsByDifference
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int diff = int.Parse(Console.ReadLine());
        int output = 0;

        for (int i = 0; i < numbers.Length -1 ; i++)
        {
            for (int j = i; j < numbers.Length; j++)
            {
                if (Math.Max(numbers[i], numbers[j]) - Math.Min(numbers[i], numbers[j]) == diff)
                {
                    output++;
                }
            }
        }

        Console.WriteLine(output);
    }
}
