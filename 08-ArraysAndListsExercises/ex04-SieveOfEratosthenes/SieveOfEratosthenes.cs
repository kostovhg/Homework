using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // bool[] primes = Enumerable.Repeat(true, n+1).ToArray();
            bool[] primes = new bool[n];

            for (int i = 2; i < n; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            List<int> result = new List<int>();

            for (int i = 2; i < n+1; i++)
            {
                if (Prime(i))
                {
                    //primes[i] = Prime(i);
                    // Console.Write(i + " ");
                    result.Add(i);
                    for (int j = i ; i * j < n; j++)
                    {
                        primes[i * j] = false;
                    }
                }

            }
            Console.WriteLine(string.Join(" ", result));


        }

        static bool IsPrime(int num) // source https://en.wikipedia.org/wiki/Primality_test
        {
            //bool prime = false;
            //if (num <= 1) return false;
            if (num <= 3) return true;
            else if (num % 2 == 0 || num % 3 == 0) return false;
            for (int i = 5; i < Math.Sqrt(num);)
            {
                if (num % i == 0 || num % (i + 2) == 0) return false;
                i += 6;
            }
            return true;
        }

        static bool Prime(int num)
        {
            bool isPrime = true;
            for (int i = 1; i <= num; i++)
            {

                for (int devider = 2; devider <= Math.Sqrt(i); devider++)
                {
                    if (i % devider == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            return isPrime;
        }
    } 
}
