using System;
using System.Numerics;

namespace ex14_FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(TrailingZeroes(n));
        }

        static int TrailingZeroes(BigInteger number)
        {
            BigInteger count = 0;

            while (number  > 0 )
            {
                count += number / 5;
                number = number / 5;
            }

            return (int)count;
        }
    }
}
