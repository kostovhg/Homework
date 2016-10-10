using System;
using System.Linq;

class CompareCharArrays
{
    static void Main(string[] args)
    {
        char[] arr1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
        char[] arr2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

        int lenArr1 = arr1.Length;
        int lenArr2 = arr2.Length;

        int minArrLen = Math.Min(lenArr1, lenArr2);

        for (int i = 0; i < minArrLen; i++)
        {
            if (arr1[i] <= arr2[i])
            {
                continue;
            }
            else 
            {
                Console.WriteLine(new string(arr2));
                Console.WriteLine(new string(arr1));
                return;
            }
        }

        if (lenArr2 < lenArr1 )
        {
            Console.WriteLine(new string(arr2));
            Console.WriteLine(new string(arr1));
        }
        else
        {
            Console.WriteLine(new string(arr1));
            Console.WriteLine(new string(arr2));
        }

    }
}
