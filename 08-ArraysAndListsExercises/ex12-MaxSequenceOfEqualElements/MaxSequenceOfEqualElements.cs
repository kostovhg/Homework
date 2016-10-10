using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        //int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<int> nums = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());

        int start = 0;
        int len = 1;
        int maxStart = 0;
        int maxLen = 1;


        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                len++;
            }
            else
            {
                start = i;
                len = 1;

            }

            if (len > maxLen)
            {
                maxStart = start;
                maxLen = len;
            }
        }

        for (int i = maxStart; i < maxStart + maxLen; i++)
        {
            Console.Write($"{nums[i]} ");
        }
    }
}
