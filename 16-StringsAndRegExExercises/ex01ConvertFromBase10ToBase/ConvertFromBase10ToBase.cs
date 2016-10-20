using System;
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

            int baseN = int.Parse(input[0]);
            double num = double.MaxValue;

            double result = ConvertBase10ToN(baseN, num);
            
        }

        private static double ConvertBase10ToN(int baseN, double num)
        {
            double resultN = 0;

            for (int i = 0; i < length; i++)
            {

            }


            return resultN;
        }
    }
}
