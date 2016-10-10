using System;

namespace ex07_ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before:\na = {a}\nb = {b}");
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
