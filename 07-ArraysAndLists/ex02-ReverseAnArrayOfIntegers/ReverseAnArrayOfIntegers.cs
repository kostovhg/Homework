using System;

namespace ex02_ReverseAnArrayOfIntegers
{
    class ReverseAnArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] revArray = new int[n];
            for (int i = n-1; i >= 0; i--)
            {
                revArray[i] = int.Parse(Console.ReadLine());
            }
            // Option 1: Print as string with joined members 
            Console.WriteLine(string.Join(" ", revArray));

            // Option 2: Print it with loop

            //for (int i = 0; i < revArray.Length; i++)
            //{
            //    Console.Write(revArray[i] + ((i == n-1) ? "\n" : " "));
            //} 
        }
    }
}
