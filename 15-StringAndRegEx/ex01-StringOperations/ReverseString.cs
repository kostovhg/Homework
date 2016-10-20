using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            char[] reverse = str.ToCharArray();

            Array.Reverse(reverse);

            Console.WriteLine(string.Join("", reverse));
        }
    }
}
