using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LongestIncreasingSubsequenceLIS
{
    static void Main(string[] args)
    {

        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //List<int> nums = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());

        //int[] nums = new int[] { 11, 12, 13, 3, 14, 4, 15, 5, 6, 7, 8, 7, 16, 9, 8 };
        //int[] nums = new int[] { 7, 3, 5, 8, -1, 0, 6, 7 };
        //int[] nums = new int[] { 0, 10, 20, 30, 30, 40, 1, 50, 2, 3, 4, 5, 6 };
        int[] len = Enumerable.Repeat(1, nums.Length).ToArray();
        int[] prev = Enumerable.Repeat(-1, nums.Length).ToArray();
        int left = 0;

        for (int i = 1; i < nums.Length; i++)
        {

            left = MaxLowerNumLenIndex(nums, len, i);
            if (left > -1) len[i] = 1 + len[left];
            prev[i] = left;
            //int left = 0;
            //for (int j = 0; j < i; j++)
            //{
            //    if (nums[i] > nums[j] && left < len[j])
            //    {
            //        left = len[j];
            //        prev[i] = j;
            //        len[i] = len[left] + 1;
            //    }
            //}

        }

        PrintResultList(len, nums, prev);
    }

    static int MaxLowerNumLenIndex(int[] array, int[] len, int p)
    {
        int[] temp = new int[p];
        for (int i = 0; i < p; i++)
        {
            if (array[p] <= array[i])
            {
                temp[i] = -1;
            }
            else
            {
                temp[i] = len[i];
            }
        }

        //if (temp.Length == 1)
        //{
        //    return -1;
        //}
        if (temp.Max() == -1)
        {
            return -1;
        }
        return Array.IndexOf(temp, temp.Max());
    }

    static void PrintResultList(int[] len, int[]nums, int[] prev)
    {
        List<int> result = new List<int>();

        for (int i = Array.IndexOf(len, len.Max()); i >= 0;)
        {
            result.Add(nums[i]);
            i = prev[i];
        }

        result.Reverse();

        Console.WriteLine(string.Join(" ", result));
    }
}