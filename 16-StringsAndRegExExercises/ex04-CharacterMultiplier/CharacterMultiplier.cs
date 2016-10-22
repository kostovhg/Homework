using System;
using System.Numerics;
using System.Linq;

namespace ex04_CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            BigInteger result = MultiplyCharArrays(input[0], input[1]);


            Console.WriteLine(result);
        }

        private static BigInteger MultiplyCharArrays(string v1, string v2)
        {

            int len1 = v1.Length;
            int len2 = v2.Length;
            int len = Math.Max(len1, len2);
            int[] str1 = Enumerable.Repeat(1, len).ToArray();
            int[] str2 = Enumerable.Repeat(1, len).ToArray();
            BigInteger sum = 0;

            for (int i = 0; i < len; i++)
            {
                str1[i] *= (i < len1) ? v1[i] : 1;
                str2[i] *= (i < len2) ? v2[i] : 1;
                sum += str1[i] * str2[i];
            }

            return sum;
        }

        //private static int[] ConvertToIntArray(string str)
        //{
        //    return str.ToCharArray()
        //            .Select(x => (int)x)
        //            .ToArray();
        //}
    }
}
