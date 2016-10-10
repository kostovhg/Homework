using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07_ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = InputArray();
            Array.Reverse(input);
            PrintArray(input);
        }

        private static string[] InputArray()
        {
            char[] sep = { ' ', ';', '@' };
            string[] arr = Console.ReadLine().Split(sep,
                StringSplitOptions.RemoveEmptyEntries).ToArray();
            return arr;
        }

        private static void PrintArray(string[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
