using System;
using System.Linq;

class MostFrequentNumber
{
    static void Main(string[] args)
    {
        ushort[] nums = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();

        // incomprehensive method found at http://stackoverflow.com/questions/19407361/find-most-common-element-in-array
        //var result = nums.GroupBy(v => v).OrderByDescending(g => g.Count()).First().Key;
        PrintValueOfMaxSeqIncElements(nums);
    }

    private static void PrintValueOfMaxSeqIncElements(ushort[] nums)
    {
        //bool[] matched = new bool[nums.Length];
        //matched[0] = true;
        int tempCount = 1;
        int maxCount = 1;
        int index = 0;

        for (int i = 0; i < nums.Length -1; i++)
        {
            for (int j = i +1; j < nums.Length /* && !matched[j] */; j++)
            {
                if (nums[i] == nums[j])
                {
                    tempCount++;
                    //matched[j] = true;
                }

            }
            if (tempCount > maxCount)
            {
                maxCount = tempCount;
                index = i;
            }
            tempCount = 1;
        }

        Console.WriteLine(nums[index]);
    }
}
