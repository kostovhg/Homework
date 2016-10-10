using System;
using System.Linq;

namespace ex02_RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrLength = arr.Length;
            int k = int.Parse(Console.ReadLine());
            int[] rotatedArray = new int[arrLength];
            int[] sumArray = new int[arrLength];

            for (int r = 1; r <= k; r++)
            {
                for (int i = 0; i < sumArray.Length; i++)
                {
                    int j = (i + r) % arrLength;
                    rotatedArray[j] = arr[i];
                    sumArray[j] += rotatedArray[j];
                }
                
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
