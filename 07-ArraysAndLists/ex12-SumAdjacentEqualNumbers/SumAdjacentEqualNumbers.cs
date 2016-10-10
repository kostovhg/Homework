using System;
using System.Collections.Generic;
using System.Linq;

namespace ex12_SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> input = new List<decimal>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList());

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1] )
                {
                    input[i] += input[i + 1];
                    input.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
