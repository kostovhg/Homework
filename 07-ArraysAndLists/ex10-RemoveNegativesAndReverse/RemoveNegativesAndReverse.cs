using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10_RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>(Console.ReadLine().Split(' ').
                Select(int.Parse).ToList());
            List<int> result = new List<int>();
            for (int i = nums.Count-1; i >= 0; i--)
            {
                if (nums[i] >= 0)
                {
                    result.Add(nums[i]);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }

        }
    }
}
