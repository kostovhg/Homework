using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main(string[] args)
        {
            double[] arr = InputArray();

            // option 1 : MidpointRounding.AwayFromZero 
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} => {RoundAwayFrom(arr[i])}");
            }


            // option 2 : custom method 
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"{arr[i]} => {AwayFrom0(arr[i])}");
            //}
        }

        private static double[] InputArray()
        {
            char[] sep = { ' ', ';', '@' };
            double[] arr = Console.ReadLine().Split(sep,
                StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            return arr;
        }

        private static double RoundAwayFrom(double n, int from = 0)
        {
            double rounded = Math.Round(n, MidpointRounding.AwayFromZero);

            return rounded;
        }

        private static int AwayFrom0(double n)
        {
            double tmp = Math.Truncate(Math.Abs(n) + 0.5);
            if (n < 0)
            {
                tmp *= -1;
            }
            int rounded = (int)tmp;
            return rounded;
        }
    }
}
