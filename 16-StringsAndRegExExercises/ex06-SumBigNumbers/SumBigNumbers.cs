using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine().TrimStart('0');
            string str2 = Console.ReadLine().TrimStart('0');

            int[] num1 = new int[Math.Max(str1.Length, str2.Length)];
            int[] num2 = new int[Math.Min(str1.Length, str2.Length)];

            if (str1.Length >= str2.Length)
            {
                num1 = StringNumTointArray(str1);
                num2 = StringNumTointArray(str2);
            }
            else
            {
                num1 = StringNumTointArray(str2);
                num2 = StringNumTointArray(str1);
            }


            Console.WriteLine(SumCharArrayNumbers(num1, num2));
            //Console.WriteLine("934573817465075391826664309019448");


        }

        private static string SumCharArrayNumbers(int[] num1, int[] num2)
        {
            int len1 = num1.Length;
            int len2 = num2.Length;
            List<int> result = new List<int>();
            int tens = 0;
            int sum = 0;

            for (int i = 0; i < len1; i++)
            {
                if (i < len2)
                {
                    sum = (num1[i] + num2[i] + tens);
                    result.Add(sum% 10);
                    tens = sum / 10;
                }
                else
                {
                    sum = (num1[i] + tens);
                    result.Add(sum %10);
                    tens = sum / 10;
                }
            }
            if (tens.Equals(1))
            {
                result.Add(1);
            }

            result.Reverse();
            
            return string.Join("", result);
        }

        public static int[] StringNumTointArray(string str)
        {
            int[] n = str
                .ToCharArray()
                .Reverse()
                .Select(x => (int)char.GetNumericValue(x))
                .ToArray();
            return n;
        }
    }
}
