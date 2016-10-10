using System;

namespace ex06_PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(ulong num) // source https://en.wikipedia.org/wiki/Primality_test
        {
            //bool prime = false;
            if (num <= 1) return false;
            else if (num <= 3) return true;
            else if (num % 2 == 0 || num % 3 == 0) return false;
            for (ulong i = 5; i < Math.Sqrt(num); )
            {
                if (num % i == 0 || num %(i + 2) == 0) return false;
                i += 6;
            }
            return true;
        }
    }
}
