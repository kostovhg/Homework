using System;
using System.Linq;

class MaximumSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int start = 0;
        int len = 1;
        int maxStart = 0;
        int maxLen = 1;


        for (int i = 1; i < nums.Length; i++)
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

        for (int i = maxStart; i < maxStart + maxLen ; i++)
        {
            Console.Write($"{nums[i]} ");
        }
    }
}
