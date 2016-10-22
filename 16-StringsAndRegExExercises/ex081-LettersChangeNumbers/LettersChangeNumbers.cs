using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ex081_LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();
            
            Regex inReg = new Regex(@"\b[a-zA-Z][0-9]{1,10}[a-zA-Z]\b");

            string[] inputLine = Console.ReadLine()
                .Split(new char[] { ' ', '\t'},
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var input in inputLine)
            {
                if (inReg.IsMatch(input))
                {
                    inputs.Add(input);
                }
            }

            double result = 0.0d;

            foreach (var str in inputs)
            {
                result += CalculateNumbersWithLetters(str);
            }

            Console.WriteLine($"{result:f2}");
        }

        private static double CalculateNumbersWithLetters(string str)
        {
            double res = 0.0d;
            int firstL = str.First();
            int lastL = str.Last();
            double num = double.Parse(Regex.Replace(str, @"[^0-9]", ""));

            if (firstL <= 'Z')
            {
                res = num / (firstL - 'A' + 1);
            }
            else
            {
                res = num * (firstL - 'a' + 1);
            }

            if (lastL <= 'Z')
            {
                res -= lastL - 'A' + 1;
            }
            else
            {
                res += lastL - 'a' + 1;
            }


            return res;
        }
    }
}
