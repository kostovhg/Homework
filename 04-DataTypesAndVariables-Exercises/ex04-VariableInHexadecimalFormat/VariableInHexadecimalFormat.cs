using System;

namespace ex04_VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hex, 16));
        }
    }
}
