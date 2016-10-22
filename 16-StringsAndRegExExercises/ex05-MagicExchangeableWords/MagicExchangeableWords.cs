using System;
using System.Collections.Generic;
using System.Linq;

namespace ex05_MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string str1 = input[0];
            string str2 = input[1];
            int len1 = str1.ToCharArray().Distinct().Count();
            int len2 = str2.ToCharArray().Distinct().Count();

            int len = Math.Min(len1, len2);

            if (len1 != len2)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 1; i < len; i++)
                {
                    bool check1 = str1[i] == str1[i - 1];
                    bool check2 = str2[i] == str2[i - 1];
                    if (check1 != check2)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                Console.WriteLine("true");
            }
        }
    }
}  