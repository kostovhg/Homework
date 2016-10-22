using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();

        List<int> result = new List<int>();

        int len1 = str1.Length;
        int len2 = str2.Length;

        int[] num1 = str1.ToCharArray()
            .Reverse()
            .Select(x => (int)char.GetNumericValue(x))
            .ToArray();
        int[] num2 = str2.ToCharArray()
            .Reverse()
            .Select(x => (int)char.GetNumericValue(x))
            .ToArray();

        int ten = 0;
        int sum = 0;

        for (int i = 0; i < Math.Max(len1, len2); i++)
        {
            if (i < len1 && i < len2)
            {
                if (i == len1 - 1 && len1 == len2 && ten != 0)
                {
                    result.Add(1);
                    continue;
                }
                sum = (num1[i] + num2[i] + ten)%10;
                result.Add(sum);
                ten = result[i] / 10;
            }
            else if (i < len1 && i >= len2)
            {
                sum = (num1[i] + ten)%10;
                ten = 0;
                result.Add(sum);
            }
            else
            {
                sum = (num2[i] + ten)%10;
                ten = 0;
                result.Add(sum);
            }

        }

        result.Reverse();

        Console.WriteLine(string.Join("", result));
    }
}
