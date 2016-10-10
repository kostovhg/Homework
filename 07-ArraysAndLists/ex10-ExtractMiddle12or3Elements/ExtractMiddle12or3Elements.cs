using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10_ExtractMiddle12or3Elements
{
    class ExtractMiddle12or3Elements
    {
        static void Main(string[] args)
        {
            int[] arrNums = Console.ReadLine().Split(' ').
                Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(", ", ExtractMiddleElements(arrNums)));
        }

        private static int[] ExtractMiddleElements(int[] arr)
        {
            int len = arr.Length;
            if (len == 1)
            {
                return arr;
            }
            else if (len % 2 == 0)
            {
                return new int[] { arr[len / 2 - 1], arr[len / 2] };
            }
            else
            {
                return new int[] { arr[len / 2 - 1], arr[len / 2], arr[len / 2 + 1] };
            }
        }

    }
}
