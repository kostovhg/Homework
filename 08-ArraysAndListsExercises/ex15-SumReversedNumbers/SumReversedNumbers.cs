using System;
using System.Linq;

class SumReversedNumbers
{
    static void Main(string[] args)
    {
        string[] series = Console.ReadLine().Split(' ').ToArray();
        int result = 0;

        for (int i = 0; i < series.Length; i++)
        {
            result += ReverseNumber(series[i]);
        }

        Console.WriteLine(result);
    }

    private static int ReverseNumber(string strNum)
    {
        int number = 0;
        char[] digits = strNum.ToCharArray();
        Array.Reverse(digits);
        strNum = new string(digits);
        number = int.Parse(strNum);
        return number;
    }
}