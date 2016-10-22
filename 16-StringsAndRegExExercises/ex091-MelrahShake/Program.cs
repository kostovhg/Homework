using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex091_MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();
            int len = pattern.Length;

            while(true)
            {
                int first = input.IndexOf(pattern);
                int last = input.LastIndexOf(pattern);
                if (first + len > last
                    || pattern.Equals(""))
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                input = input.Remove(last, len);
                input = input.Remove(first, len);
                pattern = pattern.Remove(len / 2, 1);
                len = pattern.Length;
                Console.WriteLine("Shaked it.");
            }

            Console.WriteLine(input);
        }
    }
}
