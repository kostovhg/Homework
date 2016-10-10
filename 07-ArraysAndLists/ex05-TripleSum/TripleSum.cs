using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            char[] sep = { ' ', ';', '@' };
            bool contain = false;
            long[] arr = Console.ReadLine().Split(sep, 
                StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    long sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {sum}");
                        contain = true;
                    }
                }
            }
            if (!contain)
            {
                Console.WriteLine("No");
            }
        }
    }
}
