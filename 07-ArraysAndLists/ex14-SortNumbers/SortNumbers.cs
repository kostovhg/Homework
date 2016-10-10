using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14_SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            nums.Sort();
            Console.WriteLine(string.Join(" <= ", nums));

        }
    }
}
