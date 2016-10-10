using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            // ===============================================================
            // option 1: with two nested for loops -> slow
            long[] arr = arrLastKNumSum(n, k);

            Console.WriteLine(string.Join(" ", arr));

            // ===============================================================
            //  option 2:  Nakov's solution https://youtu.be/e3pdX13ckLw?t=4039 

            //long[] arr = new long[n];
            //for (int i = 1; i < n; i++)
            //{
            //    arr[i] = SumNums(arr, i - k, i - 1);
            //}
            // ===============================================================

            // option 3 : My Special formula

            // long[] arr2 = fastArrLastKNumSum(n, k);

            // ===============================================================
            // option 4: presentation solution
            //long[] seq = new long[n];
            //seq[0] = 1;

            //for (int current = 1; current < n; current++)
            //{
            //    int start = Math.Max(0, current - k);
            //    int end = current - 1;
            //    long sum = SumValues(seq, start, end);
            //}
            // ===============================================================

            //Console.WriteLine(string.Join(" ", arr2));
        }

        //private static long SumValues(long[] seq, int start, int end)
        //{
        //    long sum = 0;
        //    for (int i = start; i < end; i++)
        //    {
        //        if (start > 0) sum += seq[i];
        //    }
        //    return sum;
        //}

        private static long[] arrLastKNumSum(int n, int k)
        {
            long[] arr = new long[n];
            arr[0] = 1;
            long sumK = arr[0];
            for (int i = 1; i < n; i++)
            {
                for (int j = 2; i - j >= 0 && k >= j; j++)
                {
                    sumK += arr[i - j];
                }
                arr[i] = sumK;
            }
            return arr;
        }
        //private static long SumNums(long[] arr, int startIndex, int endIndex)
        //{
        //    long sum = 0;
        //    for (int i = startIndex; i <= endIndex; i++)
        //    {
        //        if (i >= 0) sum += arr[i];
        //    }
        //    return sum;
        //}

        private static long[] fastArrLastKNumSum(int n, int k)
        {
            long[] arr = new long[n];
            arr[0] = 1; arr[1] = 1;

            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] * 2 - ((i - k > 0) ? (arr[i - k - 1]) : 0);
            }
            return arr;
        }
    }
}
