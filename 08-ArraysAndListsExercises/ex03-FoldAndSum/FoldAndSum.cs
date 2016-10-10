using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrLen = arr.Length;
            if (arrLen %4 != 0)
            {
                Console.WriteLine("Wrong input");
            }

            int[] firstArray = FirstRow(arr);
            int[] secondArray = SecondRow(arr);
            int[] resultArray = new int[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                resultArray[i] = firstArray[i] + secondArray[i];
            }

            Console.WriteLine(string.Join(" ", resultArray).ToString());

        }

        static int[] FirstRow(params int[] initialArray)
        {
            int k = initialArray.Length / 4;
            int[] tempArray = new int[k * 4];
            int[] firstRow = new int[k * 2];

            Array.Copy(initialArray,  tempArray, k*4);

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = tempArray[k - 1 - i];
                firstRow[k + i] = tempArray[4 * k - 1 - i];
            }

            return firstRow;
        }

        static int[] SecondRow(params int[] initialArray)
        {
            int k = initialArray.Length / 4;
            int[] tempArray = new int[k * 4];
            int[] secondRow = new int[k * 2];

            Array.Copy(initialArray, tempArray, k * 4);

            for (int i = 0; i < k*2; i++)
            {
                secondRow[i] = tempArray[k+i];
            }

            return secondRow;
        }
    }
}
