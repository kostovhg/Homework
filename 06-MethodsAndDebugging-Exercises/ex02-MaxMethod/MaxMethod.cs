using System;

namespace ex02_MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(num1, num2), GetMax(num2, num3)));
        }

        static int GetMax(int a, int b)
        {
            int max = int.MinValue;

            max = (a >= b) ? a : b;

            return max;
        }
    }
}
