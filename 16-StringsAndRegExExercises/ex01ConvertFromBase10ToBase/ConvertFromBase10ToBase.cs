using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_ConvertFromBase10ToBase
{
    class ConvertFromBase10ToBase
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string strBase = input[0];
            string strNumBase10 = input[1];

            var result = ConvertBase10ToN(strBase, strNumBase10);

            Console.WriteLine($"{result}");
            
        }

        private static string ConvertBase10ToN(string baseN, string num)
        {
            
            StringBuilder output = new StringBuilder();

            BigInteger rem = 0;
            BigInteger number = BigInteger.Parse(num);
            BigInteger bas = BigInteger.Parse(baseN);

            while (number > 0)
            {
                rem = number % BigInteger.Parse(baseN);
                number /= bas;
                output.Insert(0, rem.ToString());
            }

            
                return output.ToString();
        }
    }
}
