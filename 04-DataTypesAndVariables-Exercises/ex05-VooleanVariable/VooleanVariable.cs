using System;

namespace ex05_VooleanVariable
{
    class VooleanVariable
    {
        static void Main(string[] args)
        {
            bool input = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(input ? "Yes": "No");
        }
    }
}
