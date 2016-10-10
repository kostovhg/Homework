using System;

namespace ex04_Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", (int)Math.Ceiling((double)n/ p));
        }
    }
}
