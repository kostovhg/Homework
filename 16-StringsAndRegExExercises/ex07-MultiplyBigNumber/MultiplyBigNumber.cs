using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07_MultiplyBigNumber
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine().TrimStart('0');
            string str2 = Console.ReadLine().TrimStart('0');
            if (str2 == "")
            {
                Console.WriteLine(0);
                return;
            }

            int[] num1 = new int[str1.Length];
            int num2 = int.Parse(str2);


            num1 = StringNumTointArray(str1);

            Console.WriteLine(MultiplyCharArrayByNum(num1, num2));
        }

        private static string MultiplyCharArrayByNum(int[] num1, int num2)
        {
            List<int> result = new List<int>();
            int res = 0;
            int carry = 0;
            int add = 0;
            
            for (int i = 0; i < num1.Length; i++)
            {
                res = num2 * num1[i];
                add = res % 10 + carry;
                result.Add(add % 10);
                carry = res / 10 + add / 10;
            }

            if (carry > 0)
            {
                result.Add(carry);
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
