using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02_ConvertFromBaseNToBase10
{
    class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string strFromBase = input[0];
            string strNumBaseN = input[1];

            BigInteger result = ConvBaseNTo10(strFromBase, strNumBaseN);

            Console.WriteLine(result);
        }

        private static BigInteger ConvBaseNTo10(string fromBase, string numBaseN)
        {
            char[] charNums = numBaseN.ToCharArray().Reverse().ToArray();
            int[] inputNum = charNums.Select(x => x - 48).ToArray();
            int charArrLen = inputNum.Length;
            BigInteger res = 0;
            BigInteger bintBase = BigInteger.Parse(fromBase);

            for (int i = 0; i < charArrLen ; i++)
            {
                res += inputNum[i] * bIntPow(bintBase, i);
            }


            return res;
        }

        public static BigInteger bIntPow(BigInteger baseNum, BigInteger index)
        {
            BigInteger number = 1;
            for (BigInteger i = 0; i < index; i++)
            {
                number *= baseNum;
            }
            return number;
        }
    }
}
