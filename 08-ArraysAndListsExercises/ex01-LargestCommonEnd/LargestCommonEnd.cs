using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();

            int leftLargestCommonEnd = LargestCommonSeq(arr1, arr2);

            Array.Reverse(arr1);
            Array.Reverse(arr2);

            int rightLargestCommonEnd = LargestCommonSeq(arr1, arr2);

            Console.WriteLine(Math.Max(leftLargestCommonEnd, rightLargestCommonEnd));
          


        }

        static int LargestCommonSeq(string[] arr1, string[] arr2)
        {
            int seqLength = 0;
            int searchRange = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < searchRange; i++)
            {
                if (arr1[i].Equals(arr2[i]))
                {
                    seqLength++;
                }
                else
                {
                    break;
                }
            }

            return seqLength;
        }
    }
}
