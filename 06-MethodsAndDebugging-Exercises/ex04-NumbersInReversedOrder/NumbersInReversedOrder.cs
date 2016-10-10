using System;

namespace ex04_NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine(ReversedOrder(num));
        }

        static string ReversedOrder(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
