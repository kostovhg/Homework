using System;

namespace ex05_FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }

        static ulong Fib(int num)
        {
            ulong a = 0;
            ulong b = 1;
            ulong result = 1;
            for (int i = 0; i < num; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }
    }
}
