using System;
using System.Collections.Generic;
using System.Linq;

namespace ex15_SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            List<double> resultList = new List<double>();

            foreach (double num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    resultList.Add(num);

                }
            }
            // sort and reverse by class function
            resultList.Sort();
            resultList.Reverse();

            // sort orderby
            //resultList.OrderBy(x => x).ToList();

            // sort with lambda function
            // resultList.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", resultList));
         }
    }
}
