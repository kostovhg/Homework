using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex09_CondeseArrayToNumber
{
    class CondeseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').
                Select(int.Parse).ToArray();

            for (int r = 0; r < nums.Length - 1; r++)
            {
                for (int i = 0; i < nums.Length -1; i++)
                {
                    nums[i] = nums[i] + nums[i + 1];
                }
            }
            Console.WriteLine(nums[0]);
        }
    }
}
