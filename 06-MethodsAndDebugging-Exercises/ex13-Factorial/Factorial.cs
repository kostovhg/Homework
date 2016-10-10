using System;
using System.Numerics;

namespace ex13_Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i ;
            }

            Console.WriteLine(fact);
        }
    }
}
