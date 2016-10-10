using System;
using System.Linq;

class EqualSums
{
    static void Main(string[] args)
    {

        // need more exercises on this!!!
        byte option = 3;


        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        switch (option)
        {
            // case 0: Console.WriteLine(WithArray(nums)); break; // didn't take 100/100 from Judge
            //case 1: Console.WriteLine(WithLoops(nums)); break; // didn't take 100/100 from Judge
            //case 2: Console.WriteLine(WithLoops2(nums)); break; //again didn't pass
            case 3: CopiedFromPastebin(nums); break; // source http://pastebin.com/t9hzJcyL autor: Vasil Nikolov (chadel4e)
            default:
                break;
        }
        //int[] nums = new int[] { 1, 2, 3, 3 };
        

    }

    private static void CopiedFromPastebin(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int leftSum = SumLeft(nums, i);
            int rightSum = SumRight(nums, i);
            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine("no");
    }

    private static int SumLeft(int[] arr, int position)
    {
        int leftSum = 0;
        for (int i = position; i > 0; i--)
        {
            int nextPosition = i - 1;
            if(i == 0)
            {
                leftSum += 0;
                break;
            }
            else
            {
                leftSum += arr[nextPosition];
            }
        }
        return leftSum;
    }

    private static int SumRight(int[] arr, int position)
    {
        int rightSum = 0;

        for (int i = position; i < arr.Length; i++)
        {
            int nextPosition = (i + 1) % arr.Length;
            if (arr.Length == 1 || nextPosition == 0)
            {
                rightSum += 0;
                break;
            }
            else
            {
                rightSum += arr[nextPosition];
            }
        }
        return rightSum;
    }

    private static string WithLoops2(int[] nums)
    {
        string result = "no";
        int lSum =0;
        int rSum = nums.Skip(1).Sum();

        if (nums.Length == 1) return "0";

        for (int i = 1; i < nums.Length - 1; i++)
        {
            lSum += nums[i - 1];
            rSum -= nums[i ];
            if (lSum == rSum)
            {
                result = i.ToString();
                return result;
            }
        }

        return result;
    }

    private static string WithLoops(int[] nums)
    {
        string result = "no";

        int sumLeft, sumRight = 0;

        if (nums.Length == 1)
        {
            result = "0";
        }

        for (int i = 1; i < nums.Length-1; i++)
        {
            sumLeft = sumRight = 0;
            for (int j = 1; j  <= i; j++)
            {
                 sumLeft += nums[j - 1];
            }

            for (int j = i; j < nums.Length-1; j++)
            {
                    sumRight += nums[j + 1];
            }

            if (sumRight == sumLeft)
            {
                result = i.ToString();
                return result;

            }
        }

        return result;
    }

    private static string WithArray(int[] nums)
    {
        string result = "no";
        int[,] index = new int[2, nums.Length];
        index[0, 0] = 0;
        index[1, 0] = nums.Sum() - nums[0];
        if (index[0, 0] == index[1, 0])
        {
            result = "0";
            return result;
        }

        for (int i = 1; i < nums.Length - 1; i++)
        {
            index[0, i] = index[0, i - 1] + nums[i - 1];
            index[1, i] = index[1, i - 1] - nums[i];

            if (index[0, i] == index[1, i])
            {
                result = i.ToString();
                return result;
            }
        }
        return result;
    }
}
