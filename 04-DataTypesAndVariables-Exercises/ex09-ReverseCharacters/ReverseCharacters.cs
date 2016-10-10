using System;

namespace ex09_ReverseCharacters
{
    class ReverseCharacters
    {
        static void Main(string[] args)
        {
            char ch1 = Convert.ToChar(Console.ReadLine());
            char ch2 = Convert.ToChar(Console.ReadLine());
            char ch3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"{ch3}{ch2}{ch1}");
        }
    }
}
