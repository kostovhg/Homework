using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FindPrimes(n);
        }

        private static void FindPrimes(int n)
        {
            bool[] primes = new bool[n + 1];

            for (int i = 2; i < n + 1; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i < n+1; i++)
            {
                if (!primes[i])
                {
                    continue;
                }
                Console.Write($"{i} ");

                for (int j = i*i; j < n +1; j += i)
                {
                    primes[j] = false;
                }
            }

        }
    }
}
