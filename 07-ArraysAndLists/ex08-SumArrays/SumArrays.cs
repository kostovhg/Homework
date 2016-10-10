using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08_SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = InputArray();
            int[] arr2 = InputArray();

            int len1 = arr1.Length;
            int len2 = arr2.Length;
            int[] arr3 = new int[Math.Max(len1, len2)];
            int len3 = arr3.Length;

            for (int i = 0; i < len3; i++)
            {
                arr3[i] = arr1[i % len1] + arr2[i % len2];
            }
            PrintArray(arr3);
        }

        private static int[] InputArray()
        {
            char[] sep = { ' ', ';', '@' };
            int[] arr = Console.ReadLine().Split(sep,
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            return arr;
        }

        private static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
