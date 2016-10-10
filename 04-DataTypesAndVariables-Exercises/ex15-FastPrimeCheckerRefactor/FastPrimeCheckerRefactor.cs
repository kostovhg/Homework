using System;

namespace ex15_FastPrimeCheckerRefactor
{
    class FastPrimeCheckerRefactor
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool prime = true;
                for (int devider = 2; devider <= Math.Sqrt(i); devider++)
                {
                    if (i % devider == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }

        }
    }
}
