using System;

namespace ex01_HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Greetings(name);
        }

        static void Greetings(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
