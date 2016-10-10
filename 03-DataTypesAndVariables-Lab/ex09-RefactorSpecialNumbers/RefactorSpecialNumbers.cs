using System;

namespace ex09_RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int num = 1; num <= n; num++)
            {
                int sum = 0;
                int digits = num;
                bool special = false;
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{num} -> {special}");
            }
        }
    }
}
