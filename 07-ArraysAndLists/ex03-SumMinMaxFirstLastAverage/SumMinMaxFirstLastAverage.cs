using System;
using System.Linq;


namespace ex03_SumMinMaxFirstLastAverage
{
    class SumMinMaxFirstLastAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
            }

            // Option 1: With linq for aggregate functions 
            PrintAggergates(n, arrNumbers);

            // Option 2: With loop in method (withowt linq)
            //PrintResultArray(arrNumbers);

        }

        private static void PrintAggergates(int n, int[] arrNumbers)
        {
            Console.WriteLine("Sum = {0}", arrNumbers.Sum());
            Console.WriteLine("Min = {0}", arrNumbers.Min());
            Console.WriteLine("Max = {0}", arrNumbers.Max());
            Console.WriteLine("First = {0}", arrNumbers[0]);
            Console.WriteLine("Last = {0}", arrNumbers[n - 1]);
            Console.WriteLine("Average = {0}", arrNumbers.Average());
        }

        private static void PrintResultArray(int[] arr)
        {
            int sum = 0;
            int min = arr[0];
            int max = arr[0];
            double average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i]) min = arr[i];
                if (max < arr[i]) max = arr[i];
                sum += arr[i];       
            }
            average = (double)sum / arr.Length;
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Min = {0}",min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("First = {0}", arr[0]);
            Console.WriteLine("Last = {0}", arr[arr.Length - 1]);
            Console.WriteLine("Average = {0}", average);
        }
    }
}
